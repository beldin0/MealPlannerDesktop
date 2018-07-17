using MealPlannerApp.Forms;
using System;
using System.Windows.Forms;

namespace MealPlannerApp.Classes
{
    internal class LoginDetailsManager : IDisposable
    {
        private static readonly string file = "logindetails.txt";
        internal string Username { get; set; }
        internal string Password { get; set; }

        public DialogResult DialogResult { get; set; }

        public LoginDetailsManager()
        {
            FileIOManager fm = new FileIOManager(file);
            string[] text = fm.Read();
            if (isValidStringArray(text))
            {
                Username = text[0];
                Password = text[1];
                DialogResult = DialogResult.OK;
                return;
            }
            Wrapper<string> username = new Wrapper<string>(null);
            Wrapper<string> password = new Wrapper<string>(null);
            new GetLoginDetails() { Username = username, Password = password }.ShowDialog();
            if (username.Value != null)
            {
                fm.Write(new string[] { username, password });
                DialogResult = DialogResult.OK;
            }
        }

        private static bool isValidStringArray(string[] text)
        {
            if (text.Length != 2) return false;
            if (text[0] == "" || text[1] == "") return false;
            return true;
        }

        public void Dispose() { }
    }
}
