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
                Program.db.GetIngredients
            );
        }
        
        private static Func<bool> AddIngredientDelegate()
        {
            return delegate ()
            {
                BooleanPasser bp = new BooleanPasser();
                AddIngredient addDialog = new AddIngredient { ReturnedBool = bp };
                addDialog.ShowDialog();
                return bp.Value;
            };
        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            SharedClickFunctions(
                "Meals",
                Program.db.GetMeals
            );
        }

        private static Func<bool> AddMealDelegate(Meal m)
        {
            return delegate ()
            {
                BooleanPasser bp = new BooleanPasser();
                AddMeal addDialog = new AddMeal { ReturnedBool = bp, StarterMeal = m };
                addDialog.ShowDialog();
                return bp.Value;
            };
        }

        private void SharedClickFunctions(String ManagerType, Func<IEnumerable> DataSource)
        {
            ManagerWindow mgr = new ManagerWindow
            {
                ManagerType = ManagerType,
            };
            mgr.SetListBoxDataSource(DataSource);
            mgr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plan p = new Plan();
            p.ShowDialog();
        }
    }
}
