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
            List<string> Ingredients = ingredients.Keys.ToList<string>();
            List<String> list = new List<string>();

            string line = "";
            foreach (string ingredient in Ingredients)
            {
                if (line.Length + ingredient.Length < 90)
                {
                    line += ingredient + ",";
                }
                else
                {
                    list.Add(line);
                    line = "";
                }
            }
            
            Clipboard.SetText(list.Aggregate((a, b) => a + "\n" + b));
            System.Diagnostics.Process.Start("https://www.tesco.com/groceries/en-GB/multi-search");
        }
    }
}
