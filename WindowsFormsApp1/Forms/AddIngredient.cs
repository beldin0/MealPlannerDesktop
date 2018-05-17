using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddIngredient : Form
    {
        private bool internalChange;
        public BooleanPasser ReturnedBool;

        public AddIngredient()
        {
            InitializeComponent();
        }

        private void chkCarb_CheckedChanged(object sender, EventArgs e)
        {
            if (internalChange) return;
            if (chkCarb.Checked)
            {
                internalChange = true;
                chkProtein.Checked = false;
                internalChange = false;
            }
        }

        private void chkProtein_CheckedChanged(object sender, EventArgs e)
        {
            if (internalChange) return;
            if (chkProtein.Checked)
            {
                internalChange = true;
                chkCarb.Checked = false;
                internalChange = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text == "")
            {
                lblWarn1.Visible = true;
                return;
            }
            Program.db.Add(new Ingredient() {
                Name = txtName.Text,
                DefaultQuantityType = txtUnits.Text==""? null : txtUnits.Text,
                IsCarb = chkCarb.Checked,
                IsProtein = chkProtein.Checked
            });
            ReturnedBool.Value = true;
            Close();
        }
    }
}
