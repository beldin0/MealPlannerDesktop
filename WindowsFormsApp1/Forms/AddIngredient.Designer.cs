namespace MealPlannerApp.Forms
{
    partial class AddIngredient
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.chkCarb = new System.Windows.Forms.CheckBox();
            this.chkProtein = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWarn1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(195, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 29);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Units";
            // 
            // txtUnits
            // 
            this.txtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnits.Location = new System.Drawing.Point(195, 74);
            this.txtUnits.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(204, 29);
            this.txtUnits.TabIndex = 2;
            // 
            // chkCarb
            // 
            this.chkCarb.AutoSize = true;
            this.chkCarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarb.Location = new System.Drawing.Point(195, 119);
            this.chkCarb.Margin = new System.Windows.Forms.Padding(2);
            this.chkCarb.Name = "chkCarb";
            this.chkCarb.Size = new System.Drawing.Size(69, 28);
            this.chkCarb.TabIndex = 4;
            this.chkCarb.Text = "Carb";
            this.chkCarb.UseVisualStyleBackColor = true;
            this.chkCarb.CheckedChanged += new System.EventHandler(this.GenericCheckboxChanged);
            // 
            // chkProtein
            // 
            this.chkProtein.AutoSize = true;
            this.chkProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProtein.Location = new System.Drawing.Point(195, 150);
            this.chkProtein.Margin = new System.Windows.Forms.Padding(2);
            this.chkProtein.Name = "chkProtein";
            this.chkProtein.Size = new System.Drawing.Size(88, 28);
            this.chkProtein.TabIndex = 5;
            this.chkProtein.Text = "Protein";
            this.chkProtein.UseVisualStyleBackColor = true;
            this.chkProtein.CheckedChanged += new System.EventHandler(this.GenericCheckboxChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(75, 197);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(272, 197);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWarn1
            // 
            this.lblWarn1.AutoSize = true;
            this.lblWarn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarn1.ForeColor = System.Drawing.Color.Red;
            this.lblWarn1.Location = new System.Drawing.Point(193, 20);
            this.lblWarn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarn1.Name = "lblWarn1";
            this.lblWarn1.Size = new System.Drawing.Size(205, 17);
            this.lblWarn1.TabIndex = 8;
            this.lblWarn1.Text = "An ingredient name is required!";
            this.lblWarn1.Visible = false;
            // 
            // AddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 247);
            this.Controls.Add(this.lblWarn1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkProtein);
            this.Controls.Add(this.chkCarb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddIngredient";
            this.Text = "Add Ingredient";
            this.Shown += new System.EventHandler(this.AddIngredient_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.CheckBox chkCarb;
        private System.Windows.Forms.CheckBox chkProtein;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWarn1;
    }
}