using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    static class Dialogs
    {
        public static DialogResult QuitDialog => MessageBox.Show("Are you sure you would like to close MealPlanner?", "Quit Confirmation", MessageBoxButtons.YesNo);
    }
}
