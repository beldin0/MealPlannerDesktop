using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Collections;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class ManagerWindow : Form
    {
        public Form MyParent { get; set; }

        internal Predicate<IMealComponent> AddClickMethod = delegate (IMealComponent mc) { MessageBox.Show("Unimplemented!"); return false; };   

        private Predicate<IMealComponent> AddMealDelegate = delegate (IMealComponent m)
            {
                BooleanPasser bp = new BooleanPasser();
                AddMeal addDialog = new AddMeal { ReturnedBool = bp, StarterMeal = (Meal)m };
                addDialog.ShowDialog();
                return bp.Value;
            };

        private Predicate<IMealComponent> AddIngredientDelegate = delegate (IMealComponent i)
            {
                BooleanPasser bp = new BooleanPasser();
                AddIngredient addDialog = new AddIngredient { ReturnedBool = bp, StarterIngredient = (Ingredient)i };
                addDialog.ShowDialog();
                return bp.Value;
            };

        public string ManagerType
        {
            get => _managerType;
            set
            {
                _managerType = value;
                Text = _managerType + " Manager";
                AddClickMethod = _managerType == "Meals" ? AddMealDelegate : AddIngredientDelegate;
            }
        }

        private string _managerType;

        public IEnumerable ListBoxDataSource { get; set; }

        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void UpdateListBoxes()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var item in ListBoxDataSource)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddClickMethod(null) == true)
            {
                UpdateListBoxes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IMealComponent item = (IMealComponent)listBox1.SelectedItem;
            if (item == null) return;
            if (AddClickMethod(item) == true)
            {
                UpdateListBoxes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IMealComponent item = (IMealComponent)listBox1.SelectedItem;
            if (item != null)
            {
                switch (item.Type())
                {
                    case 'M': Program.db.Delete((Meal)item); break;
                    case 'I': {
                            if (((Ingredient)item).Meals.Count > 0)
                            {
                                if (MessageBox.Show("Are you sure you want to delete an\ningredient that is part of a meal?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) { break; };
                            }
                            Program.db.Delete((Ingredient)item);
                            break;
                        }
                }
            }
            UpdateListBoxes();
        }

        // When an item is selected, fill the linked items in the other box
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

        private void ManagerWindow_Shown(object sender, EventArgs e)
        {
            UpdateListBoxes();
        }

        private void ManagerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && DialogResult != DialogResult.OK)
            {
                var confirmation = MessageBox.Show("Are you sure you would like to close MealPlanner?", "Quit Confirmation", MessageBoxButtons.YesNo);
                e.Cancel = (confirmation == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MyParent != null) MyParent.Show();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
