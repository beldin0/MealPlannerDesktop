using MealPlannerApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class GetLoginDetails : Form
    {
        internal LoginDetails Details { get; set; }

        public GetLoginDetails()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Details.Username = txtName.Text;
            Details.Password = txtPass.Text;
            Close();
        }
    }
}
