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

namespace WindowsFormsApp1
{
    public partial class ManagerWindow : Form
    {
        public Func<bool> AddClickMethod = delegate () { MessageBox.Show("Unimplemented!"); return false; };
        private Func<IEnumerable> listBoxDataSource;

        public Func<IEnumerable> GetListBoxDataSource()
        {
            return listBoxDataSource;
        }

        public void SetListBoxDataSource(Func<IEnumerable> value)
        {
            listBoxDataSource = value;
            UpdateListBoxes();
        }

        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void UpdateListBoxes()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            IEnumerable data = GetListBoxDataSource()();
            foreach (var item in data)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddClickMethod() == true)
            {
                UpdateListBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IMealComponent item = (IMealComponent)listBox1.SelectedItem;
            if (item != null) {
                switch (item.Type())
                {
                    case 'I': Program.db.Delete((Ingredient)item); break;
                    case 'M': Program.db.Delete((Meal)item); break;
                }
            }
            UpdateListBoxes();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMealComponent item = (IMealComponent)listBox1.SelectedItem;
            if (item == null) return;
            listBox2.Items.Clear();
            foreach (var comp in item.GetLinkedComponents())
            {
                listBox2.Items.Add(comp);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
