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
        MealPlannerContext db = new MealPlannerContext();
        public Form MyParent { get; set; }
        private List<Meal> plan = new List<Meal>();
        private DataTable dataTable;
        private IEnumerable<Meal> Meals;
        private List<Meal> AvailableMeals => Meals.Except(plan).ToList();

        public Plan()
        {
            InitializeComponent();
            FillMealList();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Columns[0].Width = 175;
        }

        private void FillMealList()
        {
            if (dataTable == null)
            {
                string[] headers = { "Name", "Cooking Time", "Protein Content", "Carb Content" };
                dataTable = new DataTable();
                for (int i = 0; i < headers.Length; i++)
                {
                    dataTable.Columns.Add(headers[i]);
                }
            }
            else
            {
                dataTable.Clear();
            }

            Meals = db.GetMeals();
            foreach (Meal meal in Meals)
            {
                if (!plan.Contains(meal)) { dataTable.Add(meal); }
            }
        }

        private void AddMealToLabel(Label lbl, String mealName)
        {
            lbl.Text = mealName;
            plan.Add(Meals.Where(meal => meal.Name == mealName).Single());
            dataTable.Remove(mealName);
        }

        private void RemoveMealFromPlan(String mealName)
        {
            Meal m = Meals.Where(meal => meal.Name == mealName).Single();
            dataTable.Add(m);
            plan.Remove(m);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewMeal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillMealList();
            if (textBox1.Text != "")
            {
                string matchString = textBox1.Text.ToLower();
                for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
                {
                    string mealName = ((string)(dataTable.Rows[i].ItemArray[0])).ToLower();
                    if (!(mealName.Contains(matchString)))
                    {
                        dataTable.Rows[i].Delete();
                    }
                }
            }
        }

        private void AddNewMeal()
        {
            Wrapper<bool> Bool = new Wrapper<bool>(false);
            Meal meal = Meal.NULL;
            new AddMeal ()
            {
                ReturnedBool = Bool,
                StarterMeal = meal,
                MealName = textBox1.Text
            }
            .ShowDialog();
            if (Bool)
            {
                FillMealList();
                AddMealToPlan(meal.Name);
                textBox1.Text = "";
            };
        }

        private void AddMealToPlan(string mealName)
        {
            IEnumerable<Label> labels = this.Controls.OfType<Label>().Reverse();
            foreach (Label label in labels)
            {
                if (label.Text == "")
                {
                    AddMealToLabel(label, mealName);
                    return;
                }
            }
        }

        private void Plan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && DialogResult != DialogResult.OK)
            {
                e.Cancel = (Dialogs.QuitDialog == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MyParent != null) MyParent.Show();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> shopping = new Dictionary<string, int>();
            foreach (Meal m in plan)
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
            List<string> mealnames = plan.ToList().ConvertAll(meal => meal.Name);

            new ShoppingList()
            {
                meals = mealnames,
                ingredients = shopping,
                MyParent = this
            }.Show();
            Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt.Rows.Count == 0)
                {
                    AddNewMeal();
                }
                else
                {
                    AddMealToPlan((string)dataGridView1.CurrentRow.Cells[0].Value);
                    textBox1.Text = "";
                }
                return;
            } else if(e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
            } else
            {
                return;
            }
            if (dataGridView1.Rows.Count == 0) return;
            int index = dataGridView1.CurrentCell.RowIndex;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    index = Math.Max(index - 1, 0);
                    break;
                case Keys.Down:
                    index = Math.Min(index + 1, dataGridView1.Rows.Count - 1);
                    break;
            }
            dataGridView1.ClearSelection();
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddMealToPlan((string)dataGridView1.CurrentRow.Cells[0].Value);
            }
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

        private void GenericLabelDoubleClick(object sender, EventArgs e)
        {
            Label ClickedLabel = (Label)sender;
            if (ClickedLabel.Text == "") return;
            RemoveMealFromPlan(ClickedLabel.Text);
            ClickedLabel.Text = "";
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
            }
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            MakeSuggestions(7 - plan.Count);
        }

        private void MakeSuggestions(int number)
        {
            Wrapper<Meal> MealWrapper = new Wrapper<Meal>(null);
            for (int i = 0; i < number; i++)
            {
                MealSuggester ms = new MealSuggester(AvailableMeals);
                MealWrapper.Value = null;
                Form sv = new SuggestionViewer()
                {
                    MealWrapper = MealWrapper,
                    GetNewSource = ms.NextSuggestion
                };
                sv.ShowDialog();
                switch (sv.DialogResult)
                {
                    case DialogResult.OK:
                        AddMealToPlan(MealWrapper.Value.Name);
                        //ms.Remove(MealWrapper.Value);
                        break;

                    case DialogResult.Cancel:
                        return;

                    default:
                        i--;
                        break;
                }
                sv.Close();
            }
        }
    }
}