using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Collections;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
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
                using (AddIngredient addDialog = new AddIngredient { ReturnedBool = bp })
                {
                    addDialog.Show();
                }
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
                using (AddMeal addDialog = new AddMeal { ReturnedBool = bp, StarterMeal = m })
                {
                    addDialog.Show();
                }
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

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                var confirmation = MessageBox.Show("Are you sure you would like to close MealPlanner?", "Quit Confirmation", MessageBoxButtons.YesNo);
                e.Cancel = (confirmation == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }

        private void btnEveryWeek_Click(object sender, EventArgs e)
        {
            Form p = new EveryWeekItems() { MyParent = this };
            p.Show();
            Hide();
        }
    }
}
