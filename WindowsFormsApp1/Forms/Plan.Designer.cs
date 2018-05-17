namespace WindowsFormsApp1.Windows
{
    partial class Plan
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lstMeals = new System.Windows.Forms.ListView();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.txtMonday = new System.Windows.Forms.Label();
            this.txtTuesday = new System.Windows.Forms.Label();
            this.txtWednesday = new System.Windows.Forms.Label();
            this.txtThursday = new System.Windows.Forms.Label();
            this.txtFriday = new System.Windows.Forms.Label();
            this.txtSaturday = new System.Windows.Forms.Label();
            this.txtSunday = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMeals
            // 
            this.lstMeals.FullRowSelect = true;
            this.lstMeals.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Name";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Cooking Time";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "Protein Content";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "Carb Content";
            this.lstMeals.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.lstMeals.LabelWrap = false;
            this.lstMeals.Location = new System.Drawing.Point(12, 12);
            this.lstMeals.MultiSelect = false;
            this.lstMeals.Name = "lstMeals";
            this.lstMeals.ShowGroups = false;
            this.lstMeals.Size = new System.Drawing.Size(706, 274);
            this.lstMeals.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstMeals.TabIndex = 0;
            this.lstMeals.UseCompatibleStateImageBehavior = false;
            this.lstMeals.View = System.Windows.Forms.View.Details;
            this.lstMeals.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstMeals_ItemDrag);
            this.lstMeals.DoubleClick += new System.EventHandler(this.lstMeals_DoubleClick);
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(725, 17);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(67, 20);
            this.lblMonday.TabIndex = 2;
            this.lblMonday.Text = "Monday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(725, 57);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(72, 20);
            this.lblTuesday.TabIndex = 4;
            this.lblTuesday.Text = "Tuesday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(725, 97);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(96, 20);
            this.lblWednesday.TabIndex = 6;
            this.lblWednesday.Text = "Wednesday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(725, 137);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(78, 20);
            this.lblThursday.TabIndex = 8;
            this.lblThursday.Text = "Thursday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(725, 177);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(55, 20);
            this.lblFriday.TabIndex = 10;
            this.lblFriday.Text = "Friday";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(725, 217);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(75, 20);
            this.lblSaturday.TabIndex = 12;
            this.lblSaturday.Text = "Saturday";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(725, 257);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(64, 20);
            this.lblSunday.TabIndex = 14;
            this.lblSunday.Text = "Sunday";
            // 
            // txtMonday
            // 
            this.txtMonday.AllowDrop = true;
            this.txtMonday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMonday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonday.Location = new System.Drawing.Point(831, 17);
            this.txtMonday.Name = "txtMonday";
            this.txtMonday.Size = new System.Drawing.Size(260, 22);
            this.txtMonday.TabIndex = 15;
            this.txtMonday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtMonday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtMonday.DoubleClick += new System.EventHandler(this.GenericDoubleClick);
            // 
            // txtTuesday
            // 
            this.txtTuesday.AllowDrop = true;
            this.txtTuesday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTuesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuesday.Location = new System.Drawing.Point(831, 57);
            this.txtTuesday.Name = "txtTuesday";
            this.txtTuesday.Size = new System.Drawing.Size(260, 22);
            this.txtTuesday.TabIndex = 16;
            this.txtTuesday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtTuesday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtTuesday.DoubleClick += new System.EventHandler(this.GenericDoubleClick);
            // 
            // txtWednesday
            // 
            this.txtWednesday.AllowDrop = true;
            this.txtWednesday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWednesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWednesday.Location = new System.Drawing.Point(831, 95);
            this.txtWednesday.Name = "txtWednesday";
            this.txtWednesday.Size = new System.Drawing.Size(260, 22);
            this.txtWednesday.TabIndex = 17;
            this.txtWednesday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtWednesday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtWednesday.DoubleClick += new System.EventHandler(this.GenericDoubleClick);
            // 
            // txtThursday
            // 
            this.txtThursday.AllowDrop = true;
            this.txtThursday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtThursday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThursday.Location = new System.Drawing.Point(831, 135);
            this.txtThursday.Name = "txtThursday";
            this.txtThursday.Size = new System.Drawing.Size(260, 22);
            this.txtThursday.TabIndex = 18;
            this.txtThursday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtThursday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtThursday.DoubleClick += new System.EventHandler(this.GenericDoubleClick);
            // 
            // txtFriday
            // 
            this.txtFriday.AllowDrop = true;
            this.txtFriday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFriday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriday.Location = new System.Drawing.Point(831, 177);
            this.txtFriday.Name = "txtFriday";
            this.txtFriday.Size = new System.Drawing.Size(260, 22);
            this.txtFriday.TabIndex = 19;
            this.txtFriday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtFriday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtFriday.DoubleClick += new System.EventHandler(this.GenericDoubleClick);
            // 
            // txtSaturday
            // 
            this.txtSaturday.AllowDrop = true;
            this.txtSaturday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSaturday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaturday.Location = new System.Drawing.Point(831, 215);
            this.txtSaturday.Name = "txtSaturday";
            this.txtSaturday.Size = new System.Drawing.Size(260, 22);
            this.txtSaturday.TabIndex = 20;
            this.txtSaturday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtSaturday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtSaturday.DoubleClick += new System.EventHandler(this.GenericDoubleClick);
            // 
            // txtSunday
            // 
            this.txtSunday.AllowDrop = true;
            this.txtSunday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSunday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSunday.Location = new System.Drawing.Point(831, 255);
            this.txtSunday.Name = "txtSunday";
            this.txtSunday.Size = new System.Drawing.Size(260, 22);
            this.txtSunday.TabIndex = 21;
            this.txtSunday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtSunday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtSunday.DoubleClick += new System.EventHandler(this.GenericDoubleClick);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(364, 321);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(390, 40);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.Text = "Accept this plan";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 387);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtSunday);
            this.Controls.Add(this.txtSaturday);
            this.Controls.Add(this.txtFriday);
            this.Controls.Add(this.txtThursday);
            this.Controls.Add(this.txtWednesday);
            this.Controls.Add(this.txtTuesday);
            this.Controls.Add(this.txtMonday);
            this.Controls.Add(this.lblSunday);
            this.Controls.Add(this.lblSaturday);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.lblThursday);
            this.Controls.Add(this.lblWednesday);
            this.Controls.Add(this.lblTuesday);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.lstMeals);
            this.Name = "Plan";
            this.Text = "Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstMeals;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label txtMonday;
        private System.Windows.Forms.Label txtTuesday;
        private System.Windows.Forms.Label txtWednesday;
        private System.Windows.Forms.Label txtThursday;
        private System.Windows.Forms.Label txtFriday;
        private System.Windows.Forms.Label txtSaturday;
        private System.Windows.Forms.Label txtSunday;
        private System.Windows.Forms.Button btnAccept;
    }
}