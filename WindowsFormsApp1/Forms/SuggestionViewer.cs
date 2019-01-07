using MealPlannerApp.Classes;
using MealPlannerApp.EFClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class SuggestionViewer : Form
    {
        internal Wrapper<Meal> MealWrapper { get; set; }
        private KeyValuePair<Ingredient, List<Meal>> Source;
        internal Func<KeyValuePair<Ingredient, List<Meal>>> GetNewSource;

        public SuggestionViewer()
        {
            InitializeComponent();
        }

        private void SuggestionViewer_Load(object sender, System.EventArgs e)
        {
            BuildButtons();
        }

        private void BuildButtons()
        {
            Source = GetNewSource();
            if (Source.Key == null)
            {
                var result = Dialogs.NoMealsAvailable;
                DialogResult = DialogResult.Cancel;
                Close();
            }
            lblLabel.Text = "How about something with " + Source.Key.Name.ToLower() + "?";
            foreach (Meal m in Source.Value)
            {
                Button b = new Button()
                {
                    Text = m.Name,
                    Size = new Size(200, 100),
                    Font = new Font(lblLabel.Font.Name, 14)
                };
                b.Click += GenericButtonClick;
                cntFlow.Controls.Add(b);
            }
        }

        private void GenericButtonClick(object sender, EventArgs e)
        {
            foreach (Meal m in Source.Value)
            {
                if (m.Name == ((Button)sender).Text)
                {
                    MealWrapper.Value = m;
                    DialogResult = DialogResult.OK;
                    Hide();
                }
            }
        }

        private void SuggestionViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel) return;
            if (Visible == true)
            {
                e.Cancel = true;
                DialogResult = DialogResult.Cancel;
                Hide();
            }
        }

        private void btnResuggest_Click(object sender, EventArgs e)
        {
            Source = GetNewSource();
            cntFlow.Controls.Clear();
            BuildButtons();
        }
    }
}
