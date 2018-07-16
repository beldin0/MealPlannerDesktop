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
    public partial class EveryWeekItems : Form
    {
        public Form MyParent { get; set; }

        private const string Filename = "every week.txt";
        List<string> list;

        public EveryWeekItems()
        {
            InitializeComponent();
            FileIOManager fm = new FileIOManager(Filename);
            list = fm.Read().ToList();
            lstItems.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string item = (string)lstItems.SelectedItem;
            if (item != null)
            {
                list.Remove(item);
                lstItems.DataSource = null;
                lstItems.DataSource = list;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void AddItem()
        {
            if (txtNewItem.Text != "")
            {
                list.Add(txtNewItem.Text.ToProper());
                txtNewItem.Text = "";
                lstItems.DataSource = null;
                lstItems.DataSource = list;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FileIOManager fm = new FileIOManager(Filename);
            list.Sort();
            fm.Write(list);
            GoBack();
        }

        private void GoBack()
        {
            if (MyParent != null) MyParent.Show();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EveryWeekItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && DialogResult != DialogResult.OK)
            {
                var confirmation = MessageBox.Show("Are you sure you would like to close MealPlanner?", "Quit Confirmation", MessageBoxButtons.YesNo);
                e.Cancel = (confirmation == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }

        private void txtNewItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItem();
                return;
            }
        }
    }
}
