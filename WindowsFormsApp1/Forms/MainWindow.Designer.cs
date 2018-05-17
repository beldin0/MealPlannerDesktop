namespace WindowsFormsApp1
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
            this.Ingredients.Location = new System.Drawing.Point(304, 311);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(212, 96);
            this.Ingredients.TabIndex = 0;
            this.Ingredients.Text = "Manage Ingredients";
            this.Ingredients.UseVisualStyleBackColor = true;
            this.Ingredients.Click += new System.EventHandler(this.Ingredients_Click);
            // 
            // btnMeals
            // 
            this.btnMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeals.Location = new System.Drawing.Point(543, 311);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(212, 96);
            this.btnMeals.TabIndex = 1;
            this.btnMeals.Text = "Manage Meals";
            this.btnMeals.UseVisualStyleBackColor = true;
            this.btnMeals.Click += new System.EventHandler(this.btnMeals_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make a plan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMeals);
            this.Controls.Add(this.Ingredients);
            this.Name = "MainWindow";
            this.Text = "Meal Planner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ingredients;
        private System.Windows.Forms.Button btnMeals;
        private System.Windows.Forms.Button button1;
    }
}

