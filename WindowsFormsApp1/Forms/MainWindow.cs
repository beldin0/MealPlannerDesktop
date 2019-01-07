using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Collections;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class MainWindow : Form
    {
        private IMealPlannerContext MasterContext;
        private static IMealPlannerContext GetMasterContext() => new LocalDbContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private static Func<bool> AddIngredientDelegate()
        {
            return delegate ()
            {
                Wrapper<bool> Bool = new Wrapper<bool>(false);
                using (AddIngredient addDialog = new AddIngredient (GetMasterContext()) { ReturnedBool = Bool })
                {
                    addDialog.Show();
                }
                return Bool;
            };
        }

        private static Func<bool> AddMealDelegate(Meal m)
        {
            return delegate ()
            {
                Wrapper<bool> Bool = new Wrapper<bool>(false);
                using (AddMeal addDialog = new AddMeal (GetMasterContext()) { ReturnedBool = Bool, StarterMeal = m })
                {
                    addDialog.Show();
                }
                return Bool;
            };
        }

        private void MealsButton_Click(object sender, EventArgs e)
        {
            if (MasterContext == null) MasterContext = GetMasterContext();
            ManagerWindow mw = ManagerWindow.GetMealManager(MasterContext);
            mw.MyParent = this;
            mw.Show();
            Hide();
        }

        private void Ingredients_Click(object sender, EventArgs e)
        {
            if (MasterContext == null) MasterContext = GetMasterContext();
            ManagerWindow mw = ManagerWindow.GetIngredientManager(MasterContext);
            mw.MyParent = this;
            mw.Show();
            Hide();
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            if (MasterContext == null) MasterContext = GetMasterContext();
            Form p = new Plan(MasterContext) { MyParent = this };
            p.Show();
            Hide();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MasterContext != null)
            {
                MasterContext.Dispose();
                MasterContext = null;
            }
            Application.Exit();
        }

        private void EveryWeekButton_Click(object sender, EventArgs e)
        {
            Form p = new EveryWeekItems() { MyParent = this };
            p.Show();
            Hide();
        }

        private void MainWindow_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                if (MasterContext != null)
                {
                    MasterContext.Dispose();
                    MasterContext = null;
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
