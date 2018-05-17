using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Windows;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        ManagerWindow mgr = new ManagerWindow();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ingredients_Click(object sender, EventArgs e)
        {
            SharedClickFunctions(
                "Ingredients Manager",
                delegate () {
                    BooleanPasser bp = new BooleanPasser();
                    AddIngredient addDialog = new AddIngredient { ReturnedBool = bp };
                    addDialog.ShowDialog();
                    return bp.Value;
                },
                Program.db.GetIngredients
            );
        }
        
        private void btnMeals_Click(object sender, EventArgs e)
        {
            SharedClickFunctions(
                "Meals Manager",
                Meal.GetAddDelegate(null),
                Program.db.GetMeals
            );
        }

        private void SharedClickFunctions(String Caption, Func<bool> ClickMethod, Func<IEnumerable> DataSource)
        {
            ManagerWindow mgr = new ManagerWindow
            {
                Text = Caption,
                AddClickMethod = ClickMethod
            };
            mgr.SetListBoxDataSource(DataSource);
            mgr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plan p = new Plan();
            p.ShowDialog();
        }
    }
}
