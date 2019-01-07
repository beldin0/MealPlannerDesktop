using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class AddIngredient : Form
    {
        internal Wrapper<bool> ReturnedBool;
        private IMealPlannerContext DbContext;

        // Field to hold incoming ingredient in the case of an Edit rather than Add
        internal Ingredient StarterIngredient;

        // Property to set the ingredient name directly (e.g. adding from filter box)
        internal string IngredientName { set { txtName.Text = value.ToProper(); } }

        public AddIngredient(IMealPlannerContext db)
        {
            DbContext = db;
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

            if (StarterIngredient.Name == null)
            {
                StarterIngredient.Name = txtName.Text.ToProper();
                StarterIngredient.DefaultQuantityType = txtUnits.Text == "" ? null : txtUnits.Text;
                StarterIngredient.IsCarb = chkCarb.Checked;
                StarterIngredient.IsProtein = chkProtein.Checked;
                DbContext.Add(StarterIngredient);
            }
            else
            {
                StarterIngredient.Name = txtName.Text.ToProper();
                StarterIngredient.DefaultQuantityType = txtUnits.Text == "" ? null : txtUnits.Text;
                StarterIngredient.IsCarb = chkCarb.Checked;
                StarterIngredient.IsProtein = chkProtein.Checked;
                DbContext.SaveChanges();
            }
            ReturnedBool.Value = true;
            Close();
        }

        private void AddIngredient_Shown(object sender, EventArgs e)
        {
            if (StarterIngredient.Name != null)
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
