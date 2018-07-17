using MealPlannerApp.Classes;
using System;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class GetLoginDetails : Form
    {
        internal Wrapper<string> Username { get; set; }
        internal Wrapper<string> Password { get; set; }

        public GetLoginDetails()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Username.Value = txtName.Text;
            Password.Value = txtPass.Text;
            Close();
        }
    }
}
