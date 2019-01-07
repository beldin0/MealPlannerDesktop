using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class ManagerWindow : Form
    {
        internal IMealPlannerContext db;

        public Form MyParent { get; set; }

        internal Predicate<IMealComponent> AddClickMethod = delegate (IMealComponent mc) { var result = Dialogs.Unimplemented; return false; };

        private Predicate<IMealComponent> AddMealDelegate => delegate (IMealComponent m)
            {
                //if (db == null) { db = new MealPlannerContext(); }
                Wrapper<bool> Bool = new Wrapper<bool>(false);
                if (m == null) { m = Meal.NULL; }
                using (AddMeal addDialog = new AddMeal(db) { ReturnedBool = Bool, StarterMeal = (Meal)m })
                {
                    addDialog.ShowDialog();
                }
                return Bool;
            };

        private Predicate<IMealComponent> AddIngredientDelegate => delegate (IMealComponent i)
        {
            //if (db == null) { db = new MealPlannerContext(); }
            Wrapper<bool> Bool = new Wrapper<bool>(false);
            if (i == null) { i = Ingredient.NULL; }
            using (AddIngredient addDialog = new AddIngredient(db) { ReturnedBool = Bool, StarterIngredient = (Ingredient)i })
            {
                addDialog.ShowDialog();
            }
            return Bool;
        };

        public IEnumerable ListBoxDataSource { get; set; }

        private ManagerWindow()
        {
            InitializeComponent();
        }

        private void UpdateListBoxes()
        {
            listBox1.DataSource = null;
            listBox2.Items.Clear();
            List<IMealComponent> list = new List<IMealComponent>();
            foreach (IMealComponent item in ListBoxDataSource)
            {
                list.Add(item);
            }
            list.Sort();
            listBox1.DataSource = list;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddClickMethod(null) == true)
            {
                UpdateListBoxes();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            IMealComponent item = (IMealComponent)listBox1.SelectedItem;
            if (item == null) return;
            if (AddClickMethod(item) == true)
            {
                UpdateListBoxes();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            IMealComponent item = (IMealComponent)listBox1.SelectedItem;
            if (item != null)
            {
                item.DeleteFrom(db);
                item = null;
                UpdateListBoxes();
            }
        }

        // When an item is selected, fill the linked items in the other box
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
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
                e.Cancel = (Dialogs.QuitDialog == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MyParent != null) MyParent.Show();
            DialogResult = DialogResult.OK;
            Close();
        }

        public static ManagerWindow GetMealManager(IMealPlannerContext db)
        {
            ManagerWindow mw = new ManagerWindow() {
                Text = "Meal Manager",
                db = db,
                ListBoxDataSource = db.GetMeals()
            };
            mw.AddClickMethod = mw.AddMealDelegate;
            return mw;
        }

        public static ManagerWindow GetIngredientManager(IMealPlannerContext db)
        {
            ManagerWindow mw = new ManagerWindow()
            {
                Text = "Ingredient Manager",
                db = db,
                ListBoxDataSource = db.GetIngredients()
            };
                        mw.AddClickMethod = mw.AddIngredientDelegate;
            return mw;
        }
    }
}
