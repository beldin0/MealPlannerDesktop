using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MealPlannerApp.Windows;

namespace MealPlannerApp
{
    public partial class MainWindow : Form
    {
        ManagerWindow mgr = new ManagerWindow();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ingredients_Click(object sender, EventArgs e)
        {
            SharedClickFunctions(
                "Ingredients",
                Program.db.GetIngredients()
            );
        }
        
        private static Func<bool> AddIngredientDelegate()
        {
            return delegate ()
            {
                BooleanPasser bp = new BooleanPasser();
                AddIngredient addDialog = new AddIngredient { ReturnedBool = bp };
                addDialog.Show();
                return bp.Value;
            };
        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            SharedClickFunctions(
                "Meals",
                Program.db.GetMeals()
            );
        }

        private static Func<bool> AddMealDelegate(Meal m)
        {
            return delegate ()
            {
                BooleanPasser bp = new BooleanPasser();
                AddMeal addDialog = new AddMeal { ReturnedBool = bp, StarterMeal = m };
                addDialog.Show();
                return bp.Value;
            };
        }

        private void SharedClickFunctions(String ManagerType, IEnumerable DataSource)
        {
            Form mgr = new ManagerWindow
            {
                ManagerType = ManagerType,
                ListBoxDataSource = DataSource,
                MyParent = this
            };
            mgr.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form p = new Plan() { MyParent = this };
            p.Show();
            Hide();
        }
    }
}
