using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class ShoppingList : Form
    {
        internal List<string> meals;
        internal Dictionary<string, int> ingredients;

        public ShoppingList()
        {
            InitializeComponent();
        }

        private void ShoppingList_Shown(object sender, EventArgs e)
        {
            lstMeals.DataSource = meals;
            lstIngredients.DataSource = ingredients.Keys.ToList<string>();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(ingredients.Keys.ToList<string>().Aggregate((a,b) => a + ", " + b));
            System.Diagnostics.Process.Start("https://www.tesco.com/groceries/en-GB/multi-search");
        }
    }
}
