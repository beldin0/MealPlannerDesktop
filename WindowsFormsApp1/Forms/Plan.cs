using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class Plan : Form
    {
        private static readonly string[] headers = {"Name", "Cooking Time", "Protein Content", "Carb Content" };
        private List<Meal> meals= new List<Meal>();
        private DataTable dataTable;

        public Form MyParent { get; set; }

        public Plan()
        {
            InitializeComponent();
            dataTable = NewDataTable();
            SetDataGridViewSource(dataTable);
            FillMealList();
        }

        private DataTable NewDataTable()
        {
            DataTable d = new DataTable();
            for (int i = 0; i < headers.Length; i++) { d.Columns.Add(headers[i]); }
            return d;
        }

        private void SetDataGridViewSource(DataTable dataTable, bool sort=true)
        {
            this.dataTable = dataTable;
            dataGridView1.DataSource = dataTable;
            if (sort) dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void FillMealList(DataTable dt = null)
        {
            if (dt == null)
            {
                dataTable.Rows.Clear();
                dt = dataTable;
            }
            foreach (Meal m in Program.db.GetMeals())
            {
                if (!meals.Contains(m)) { AddToTable(dt, m); }
            }
        }

        private void AddToTable(DataTable table, Meal m)
        {
            DataRow d = table.NewRow();
            d[0] = m.Name;
            d[1] = m.CookTime;
            d[2] = m.GetProtein();
            d[3] = m.GetCarb();
            table.Rows.Add(d);
        }

        private void GenericDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string))) { e.Effect = DragDropEffects.Move; }
        }

        private void GenericDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                Label lbl = ((Label)sender);
                string mealName = (string)e.Data.GetData(typeof(string));
                if (lbl.Text != "") { RemoveMealFromPlan(lbl.Text); }
                AddMealToLabel(lbl, mealName);
                FillMealList();
            }
        }

        private void AddMealToLabel(Label lbl, String MealName)
        {
            lbl.Text = MealName;
            meals.Add(Program.db.GetMeals().Where(meal => meal.Name == MealName).First<Meal>());
        }

        private void GenericLabelDoubleClick(object sender, EventArgs e)
        {
            Label ClickedLabel = (Label)sender;
            if (ClickedLabel.Text == "") return;
            RemoveMealFromPlan(ClickedLabel.Text);
            ClickedLabel.Text = "";
        }

        private void RemoveMealFromPlan(String MealName)
        {
            Meal m = Program.db.GetMeals().Where(meal => meal.Name == MealName).First<Meal>();
            AddToTable(dataTable, m);
            meals.Remove(m);
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
            List<string> mealnames = meals.ToList<Meal>().ConvertAll<string>(meal => meal.Name);

            Form sl = new ShoppingList()
            {
                meals = mealnames,
                ingredients = shopping,
                MyParent = this
            };
            sl.Show();
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BooleanPasser bp = new BooleanPasser();
            AddMeal addDialog = new AddMeal { ReturnedBool = bp, StarterMeal = null };
            addDialog.MealName = textBox1.Text;
            addDialog.ShowDialog();
            if (bp.Value)
            {
                FillMealList();
                AddMealToPlan(((Meal)bp.Component).Name);
                textBox1.Text = "";
            };
        }

        private void AddMealToPlan(string mealName)
        {
            int selectedRow = -1;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if ((string)dataTable.Rows[i].ItemArray[0] == mealName)
                {
                    selectedRow = i;
                    break;
                }
            }
            if (selectedRow < 0) return;

            IEnumerable<Label> labels = this.Controls.OfType<Label>().Reverse();
            foreach (Label label in labels)
            {
                if (label.Text == "")
                {
                    AddMealToLabel(label, mealName);
                    dataTable.Rows[selectedRow].Delete();
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = NewDataTable();
            FillMealList(dt);
            if (textBox1.Text!="")
            {
                for (int i=dt.Rows.Count-1; i>=0; i--)
                {
                    if (!((string)dt.Rows[i].ItemArray[0]).ToLower().Contains(textBox1.Text.ToLower())) {
                        dt.Rows[i].Delete();
                    }
                }
            }
            SetDataGridViewSource(dt);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DataGridView.HitTestInfo info = dataGridView1.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    dataGridView1.Rows[info.RowIndex].Selected = true;
                    string text = (String)dataGridView1.Rows[info.RowIndex].Cells[0].Value;
                    if (text != null)
                    {
                        dataGridView1.DoDragDrop(text, DragDropEffects.Move);
                    }
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo info = dataGridView1.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    string mealName = (string)dataGridView1.Rows[info.RowIndex].Cells[0].Value;
                    AddMealToPlan(mealName);
                    textBox1.Text = "";
                    textBox1.Select();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MyParent != null) MyParent.Show();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Plan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && DialogResult != DialogResult.OK)
            {
                var confirmation = MessageBox.Show("Are you sure you would like to close MealPlanner?", "Quit Confirmation", MessageBoxButtons.YesNo);
                e.Cancel = (confirmation == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }
    }
}
