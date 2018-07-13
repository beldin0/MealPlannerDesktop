using MealPlannerApp.Forms;
using System;
using System.Windows.Forms;

namespace MealPlannerApp.Classes
{
    internal static class LoginDetailsManager
    {
        private static readonly string file = "logindetails.txt";

        public static LoginDetails GetLoginDetails()
        {
            LoginDetails details = null;
            FileIOManager fm = new FileIOManager(file);
            string[] text = fm.Read();
            if (isValidStringArray(text))
            {
                string username = text[0];
                string password = text[1];
                details = new LoginDetails(username, password);
            }
            if (details == null)
            {
                details = new LoginDetails();
                Form getLogin = new GetLoginDetails() { Details = details };
                getLogin.ShowDialog();
                if (details != null)
                {
                    fm.Write(details.AsStringArray());
                }
            }
            return details;
        }

        private static bool isValidStringArray(string[] text)
        {
            if (text.Length != 2) return false;
            if (text[0] == "" || text[1] == "") return false;
            return true;
        }
    }
}
