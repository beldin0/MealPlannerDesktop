using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    static class Dialogs
    {
        public static DialogResult QuitDialog => MessageBox.Show("Are you sure you would like to close MealPlanner?", "Quit Confirmation", MessageBoxButtons.YesNo);

        public static DialogResult ConfirmDelete => MessageBox.Show("Are you sure you want to delete an\ningredient that is part of a meal?", "Confirm", MessageBoxButtons.YesNo);

        public static DialogResult Unimplemented => MessageBox.Show("This function is not implemented yet!");

        public static object NoMealsAvailable => MessageBox.Show("No meals meet the criteria!");
    }
}
