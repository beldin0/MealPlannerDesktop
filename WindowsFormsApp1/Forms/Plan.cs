using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Windows
{
    public partial class Plan : Form
    {
        private readonly string[] headers = {"Name", "Cooking Time", "Protein Content", "Carb Content" };
        private static List<Meal> meals = new List<Meal>();
        public Plan()
        {
            InitializeComponent();
            InitializeMealList();
        }

        private void InitializeMealList()
        {
            for (int i = 0; i < headers.Length; i++)
            {
                lstMeals.Columns.Add(new ColumnHeader());
                lstMeals.Columns[i].Text = headers[i];
                lstMeals.Columns[i].Width = (i == 0 ? 250 : 150);
            }

            foreach (Meal m in Program.db.GetMeals())
            {
                lstMeals.Items.Add(ConvertToListViewItem(m));
            }
            
        }

        private ListViewItem ConvertToListViewItem(Meal m)
        {
            return new ListViewItem(new string[] {m.Name, m.CookTime, m.GetProtein(), m.GetCarb() });
        }

        private void lstMeals_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void GenericDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent (typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void GenericDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                Label lbl = ((Label)sender);
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                AddMealToLabel(lbl, item);
            }
        }

        private static void AddMealToLabel(Label lbl, ListViewItem item)
        {
            lbl.Text = item.Text;
            meals.Add(Program.db.GetMeals().Where(meal => meal.Name == lbl.Text).First<Meal>());
            item.ListView.Items.Remove(item);
        }

        private void GenericDoubleClick(object sender, EventArgs e)
        {
            Label ClickedLabel = (Label)sender;
            if (ClickedLabel.Text == "") return;
            RemoveMealFromPlan(ClickedLabel.Text);
            ClickedLabel.Text = "";
        }

        private void RemoveMealFromPlan(String MealName)
        {
            Meal m = Program.db.GetMeals().Where(meal => meal.Name == MealName).First<Meal>();
            lstMeals.Items.Add(ConvertToListViewItem(m));
            meals.Remove(m);
        }

        private void lstMeals_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lstMeals.SelectedItems[0]; 
            IEnumerable<Label> labels = this.Controls.OfType<Label>().Reverse();
            foreach (Label label in labels)
            {
                if (label.Text == "") {
                    AddMealToLabel(label, item);
                    return;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> shopping = new Dictionary<string, int>();
            foreach (Meal m in meals)
            {
                foreach (Ingredient i in m.Ingredients)
                {
                    if (shopping.ContainsKey(i.Name))
                    {
                        shopping[i.Name] += 1;
                    } else
                    {
                        shopping.Add(i.Name, 1);
                    }
                }
            }
            List<string> mealnames = meals.ToList<Meal>().ConvertAll<string>(m => m.Name);

            ShoppingList sl = new ShoppingList();
            sl.meals = mealnames;
            sl.ingredients = shopping;
            sl.Show();
            Close();
        }
    }
}
