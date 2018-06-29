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
        internal BooleanPasser ReturnedBool;

        // Field to hold incoming ingredient in the case of an Edit rather than Add
        internal Ingredient StarterIngredient;

        // Property to set the ingredient name directly (e.g. adding from filter box)
        internal string IngredientName { set { this.txtName.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower()); } }

        public AddIngredient()
        {
            InitializeComponent();
        }


        // Both Carb and Protein check boxes cannot be checked at the same time
        private void GenericCheckboxChanged(object sender, EventArgs e)
        {
            if (chkCarb == sender && chkCarb.Checked) chkProtein.Checked = false;
            else if (chkProtein == sender && chkProtein.Checked) chkCarb.Checked = false;
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

            if (StarterIngredient == null)
            {
                StarterIngredient = new Ingredient() {
                    Name = txtName.Text,
                    DefaultQuantityType = txtUnits.Text==""? null : txtUnits.Text,
                    IsCarb = chkCarb.Checked,
                    IsProtein = chkProtein.Checked
                };
                Program.db.Add(StarterIngredient);
                ReturnedBool.Component = StarterIngredient; // Passes the new ingredient back to be used in the meal if navigated from there
            }
            else
            {
                StarterIngredient.Name = txtName.Text;
                StarterIngredient.DefaultQuantityType = txtUnits.Text == "" ? null : txtUnits.Text;
                StarterIngredient.IsCarb = chkCarb.Checked;
                StarterIngredient.IsProtein = chkProtein.Checked;
                Program.db.SaveChanges();
            }
            ReturnedBool.Value = true;
            Close();
        }

        private void AddIngredient_Shown(object sender, EventArgs e)
        {
            if (StarterIngredient != null)
            {
                Text = "Edit Ingredient";
                txtName.Text = StarterIngredient.Name;
                txtUnits.Text = StarterIngredient.DefaultQuantityType;
                chkCarb.Checked = StarterIngredient.IsCarb;
                chkProtein.Checked = StarterIngredient.IsProtein;
            }
        }
    }
}
