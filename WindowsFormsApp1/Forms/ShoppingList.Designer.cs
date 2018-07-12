namespace MealPlannerApp.Forms
{
    partial class ShoppingList
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
            this.lstMeals = new System.Windows.Forms.ListBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMeals
            // 
            this.lstMeals.FormattingEnabled = true;
            this.lstMeals.Location = new System.Drawing.Point(40, 32);
            this.lstMeals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMeals.Name = "lstMeals";
            this.lstMeals.Size = new System.Drawing.Size(372, 95);
            this.lstMeals.TabIndex = 0;
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(42, 138);
            this.lstIngredients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(370, 212);
            this.lstIngredients.TabIndex = 1;
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(152, 366);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(151, 34);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop!";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 410);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lstMeals);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShoppingList";
            this.Text = "Shopping List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShoppingList_FormClosed);
            this.Shown += new System.EventHandler(this.ShoppingList_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeals;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnShop;
    }
}