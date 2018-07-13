namespace MealPlannerApp.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ingredients = new System.Windows.Forms.Button();
            this.btnMeals = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ingredients
            // 
            this.Ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredients.Location = new System.Drawing.Point(228, 253);
            this.Ingredients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(159, 78);
            this.Ingredients.TabIndex = 0;
            this.Ingredients.Text = "Manage Ingredients";
            this.Ingredients.UseVisualStyleBackColor = true;
            this.Ingredients.Click += new System.EventHandler(this.Ingredients_Click);
            // 
            // btnMeals
            // 
            this.btnMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeals.Location = new System.Drawing.Point(407, 253);
            this.btnMeals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(159, 78);
            this.btnMeals.TabIndex = 1;
            this.btnMeals.Text = "Manage Meals";
            this.btnMeals.UseVisualStyleBackColor = true;
            this.btnMeals.Click += new System.EventHandler(this.btnMeals_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make a plan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMeals);
            this.Controls.Add(this.Ingredients);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "Meal Planner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ingredients;
        private System.Windows.Forms.Button btnMeals;
        private System.Windows.Forms.Button button1;
    }
}

