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
        public BooleanPasser ReturnedBool;
        internal Meal StarterMeal;

        public AddMeal()
        {
            InitializeComponent();
            cboCookTime.DataSource = Meal.CookingTime.GetCookTimes();
        }

        private void ReloadIngredients()
        {
            lstAvailable.Items.Clear();
            List<Ingredient> used = lstUsed.Items.OfType<Ingredient>().ToList<Ingredient>();
            foreach (var item in Program.db.GetIngredients())
            {
                if (used.Contains(item)) continue;
                lstAvailable.Items.Add(item);
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
            if (StarterMeal == null) StarterMeal = new Meal();
            StarterMeal.Name = txtName.Text;
            StarterMeal.CookTime = cboCookTime.Text;
            StarterMeal.Ingredients = new List<Ingredient>();
            foreach (var item in lstUsed.Items)
            {
                StarterMeal.Ingredients.Add((Ingredient)item);
            }

            Program.db.Add(StarterMeal);
            ReturnedBool.Value = true;
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
            addDialog.ShowDialog();
            if (bp.Value) ReloadIngredients();
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
    }
}
