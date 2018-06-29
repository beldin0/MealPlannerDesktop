using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddMeal : Form
    {
        internal BooleanPasser ReturnedBool;

        // Field to hold incoming meal in the case of an Edit rather than Add
        internal Meal StarterMeal;

        // Property to set the meal name directly (e.g. adding from filter box)
        public string MealName { set { this.txtName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower()); } }

        public AddMeal()
        {
            InitializeComponent();
            cboCookTime.DataSource = Meal.CookingTime.GetCookTimes();
        }

        private void ReloadIngredients(Func<Ingredient, bool> Pred = null)
        {
            if (Pred == null) Pred = delegate (Ingredient i) { return !lstUsed.Items.OfType<Ingredient>().ToList<Ingredient>().Contains(i); };
            lstAvailable.Items.Clear();
            foreach (var item in Program.db.GetIngredients())
            {
                if (Pred(item)) lstAvailable.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSelectedItem();
        }

        private void AddSelectedItem()
        {
            var item = lstAvailable.SelectedItem;
            if (item == null) return;
            lstUsed.Items.Add(item);
            lstAvailable.Items.Remove(item);
            textBox1.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var item = lstUsed.SelectedItem;
            if (item == null) return;
            lstAvailable.Items.Add(item);
            lstUsed.Items.Remove(item);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text == "")
            {
                lblWarn1.Visible = true;
                return;
            }
            if (StarterMeal != null)
            {
                Program.db.Delete(StarterMeal);
            }
            StarterMeal = new Meal();
            StarterMeal.Name = txtName.Text;
            StarterMeal.CookTime = cboCookTime.Text;
            StarterMeal.Ingredients = new List<Ingredient>();
            foreach (var item in lstUsed.Items)
            {
                StarterMeal.Ingredients.Add((Ingredient)item);
            }

            Program.db.Add(StarterMeal);
            ReturnedBool.Value = true;
            ReturnedBool.Component = StarterMeal; // Passes the new meal back to be used in the Plan if navigated from there
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            BooleanPasser bp = new BooleanPasser();
            AddIngredient addDialog = new AddIngredient { ReturnedBool = bp };
            addDialog.IngredientName = textBox1.Text;
            addDialog.ShowDialog();
            if (bp.Value) {
                if (bp.HasComponent)
                {
                    lstUsed.Items.Add(bp.Component);
                    textBox1.Text = "";
                }
            }
        }

        private void AddMeal_Shown(object sender, EventArgs e)
        {
            if (StarterMeal != null)
            {
                txtName.Text = StarterMeal.Name;
                cboCookTime.Text = StarterMeal.CookTime;
                foreach (var i in StarterMeal.Ingredients)
                {
                    lstUsed.Items.Add(i);
                }
            }
            ReloadIngredients();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Func<Ingredient, bool> Pred = null;
            if (textBox1.Text != "") Pred = delegate (Ingredient i) { return i.Name.ToLower().Contains(textBox1.Text.ToLower()); };
            ReloadIngredients(Pred);
        }
    }
}
