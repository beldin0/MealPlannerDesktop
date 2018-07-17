using MealPlannerApp.Classes;
using MealPlannerApp.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class ShoppingList : Form
    {
        internal List<string> meals;
        internal Dictionary<string, int> ingredients;
        internal IShoppingManager shoppingManager;
        public Form MyParent { get; set; }

        public ShoppingList()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.AddRange(ingredients.Keys);
            using (FileIOManager fm = new FileIOManager("every week.txt"))
            {
                list.AddRange(fm.Read());
            }
            using (LoginDetailsManager login = new LoginDetailsManager())
            {
                if (login.DialogResult != DialogResult.OK) return;
                shoppingManager = new TescoShoppingManager() { LoginUserName = login.Username, LoginPassword = login.Password };
                shoppingManager.DoShopping(list);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MyParent != null) MyParent.Show();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ShoppingList_Shown(object sender, EventArgs e)
        {
            lstMeals.DataSource = meals;
            lstIngredients.DataSource = ingredients.Keys.ToList();
        }

        private void ShoppingList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && DialogResult != DialogResult.OK)
            {
                e.Cancel = (Dialogs.QuitDialog == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }

        private void ShoppingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shoppingManager != null)
            {
                shoppingManager.Deregister();
            }
        }
    }
}
