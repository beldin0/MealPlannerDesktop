using System;

namespace MealPlannerApp.Classes
{
    class LoginDetails : IDisposable
    {

        public string Password { get; set; }

        public string Username { get; set; }

        public LoginDetails()
        {
            Username = "";
            Password = "";
        }

        public LoginDetails(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string[] AsStringArray()
        {
            return new string[] { Username, Password };
        }

        public void Dispose() { }
    }
}
