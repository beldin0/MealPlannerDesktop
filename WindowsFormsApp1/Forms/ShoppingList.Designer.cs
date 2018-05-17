namespace WindowsFormsApp1.Forms
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
            this.lstMeals.ItemHeight = 16;
            this.lstMeals.Location = new System.Drawing.Point(53, 39);
            this.lstMeals.Name = "lstMeals";
            this.lstMeals.Size = new System.Drawing.Size(495, 116);
            this.lstMeals.TabIndex = 0;
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 16;
            this.lstIngredients.Location = new System.Drawing.Point(56, 170);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(492, 260);
            this.lstIngredients.TabIndex = 1;
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(202, 450);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(201, 42);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop!";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 504);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lstMeals);
            this.Name = "ShoppingList";
            this.Text = "Shopping List";
            this.Shown += new System.EventHandler(this.ShoppingList_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeals;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnShop;
    }
}