using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class AddMeal : Form
    {
        internal Wrapper<bool> ReturnedBool;
        internal IMealPlannerContext DbContext { get; set; }

        // Field to hold incoming meal in the case of an Edit rather than Add
        internal Meal StarterMeal;

        // Property to set the meal name directly (e.g. adding from filter box)
        public string MealName { set { this.txtName.Text = value.ToProper(); } }

        public AddMeal(IMealPlannerContext db)
        {
            InitializeComponent();
            DbContext = db;
            cboCookTime.DataSource = Meal.CookingTime.GetCookTimes();
        }

        private void ReloadIngredients(Func<Ingredient, bool> Pred = null)
        {
            IEnumerable<Ingredient> ingredients = DbContext.GetIngredients();
            if (Pred == null) Pred = delegate (Ingredient i) { return !lstUsed.Items.OfType<Ingredient>().ToList<Ingredient>().Contains(i); };
            lstAvailable.Items.Clear();
            foreach (Ingredient ingredient in ingredients)
                {
                    if (ingredient != null)
                    {
                        if (Pred(ingredient)) lstAvailable.Items.Add(ingredient);
                    }
                }
        }

        private void AddButton_Click(object sender, EventArgs e)
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var item = lstUsed.SelectedItem;
            if (item == null) return;
            lstAvailable.Items.Add(item);
            lstUsed.Items.Remove(item);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text == "")
            {
                lblWarn1.Visible = true;
                return;
            }
            if (StarterMeal.Name != null) DbContext.Delete(StarterMeal); 
            StarterMeal.Name = txtName.Text.ToProper();
            StarterMeal.CookTime = cboCookTime.Text;
            StarterMeal.Ingredients.Clear();
            foreach (var item in lstUsed.Items)
            {
                StarterMeal.Ingredients.Add((Ingredient)item);
            }
            DbContext.Add(StarterMeal);
            DbContext.SaveChanges();
            ReturnedBool.Value = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            Wrapper<bool> Bool = new Wrapper<bool>(false);
            Ingredient ingredient = Ingredient.NULL;
            ingredient.Name = textBox1.Text;
            using (AddIngredient addDialog = new AddIngredient(DbContext) { ReturnedBool = Bool, StarterIngredient = ingredient })
            {
                addDialog.ShowDialog();
            }
            if (Bool)
            {
                lstUsed.Items.Add(ingredient);
                textBox1.Text = "";
            }
        }

        private void AddMeal_Shown(object sender, EventArgs e)
        {
            if (StarterMeal.Name != null)
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Func<Ingredient, bool> Pred = null;
            if (textBox1.Text != "") Pred = delegate (Ingredient i) { return i.Name.ToLower().Contains(textBox1.Text.ToLower()); };
            ReloadIngredients(Pred);
        }
    }
}
