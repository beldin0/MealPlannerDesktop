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
            MealPlannerContext db = new MealPlannerContext();
            SharedClickFunctions(
                "Ingredients",
                db.GetIngredients()
            );
        }

        private static Func<bool> AddIngredientDelegate()
        {
            return delegate ()
            {
                Wrapper<bool> Bool = new Wrapper<bool>(false);
                using (AddIngredient addDialog = new AddIngredient { ReturnedBool = Bool })
                {
                    addDialog.Show();
                }
                return Bool;
            };
        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            MealPlannerContext db = new MealPlannerContext();
            SharedClickFunctions(
                "Meals",
                db.GetMeals()
            );
        }

        private static Func<bool> AddMealDelegate(Meal m)
        {
            return delegate ()
            {
                Wrapper<bool> Bool = new Wrapper<bool>(false);
                using (AddMeal addDialog = new AddMeal { ReturnedBool = Bool, StarterMeal = m, db = new MealPlannerContext() })
                {
                    addDialog.Show();
                }
                return Bool;
            };
        }

        private void SharedClickFunctions(String ManagerType, IEnumerable DataSource)
        {
            new ManagerWindow
            {
                ManagerType = ManagerType,
                ListBoxDataSource = DataSource,
                MyParent = this
            }.Show();
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
                e.Cancel = (Dialogs.QuitDialog == DialogResult.No);
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
