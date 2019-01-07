namespace MealPlannerApp.Forms
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
                db.Dispose();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSuggest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(544, 14);
            this.lblMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(65, 17);
            this.lblMonday.TabIndex = 2;
            this.lblMonday.Text = "Saturday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(544, 46);
            this.lblTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(56, 17);
            this.lblTuesday.TabIndex = 4;
            this.lblTuesday.Text = "Sunday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(544, 79);
            this.lblWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(58, 17);
            this.lblWednesday.TabIndex = 6;
            this.lblWednesday.Text = "Monday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(544, 111);
            this.lblThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(63, 17);
            this.lblThursday.TabIndex = 8;
            this.lblThursday.Text = "Tuesday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(544, 144);
            this.lblFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(83, 17);
            this.lblFriday.TabIndex = 10;
            this.lblFriday.Text = "Wednesday";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(544, 176);
            this.lblSaturday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(68, 17);
            this.lblSaturday.TabIndex = 12;
            this.lblSaturday.Text = "Thursday";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(544, 209);
            this.lblSunday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(47, 17);
            this.lblSunday.TabIndex = 14;
            this.lblSunday.Text = "Friday";
            // 
            // txtMonday
            // 
            this.txtMonday.AllowDrop = true;
            this.txtMonday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMonday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonday.Location = new System.Drawing.Point(623, 14);
            this.txtMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMonday.Name = "txtMonday";
            this.txtMonday.Size = new System.Drawing.Size(196, 18);
            this.txtMonday.TabIndex = 15;
            this.txtMonday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtMonday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtMonday.DoubleClick += new System.EventHandler(this.GenericLabelDoubleClick);
            // 
            // txtTuesday
            // 
            this.txtTuesday.AllowDrop = true;
            this.txtTuesday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTuesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuesday.Location = new System.Drawing.Point(623, 46);
            this.txtTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTuesday.Name = "txtTuesday";
            this.txtTuesday.Size = new System.Drawing.Size(196, 18);
            this.txtTuesday.TabIndex = 16;
            this.txtTuesday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtTuesday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtTuesday.DoubleClick += new System.EventHandler(this.GenericLabelDoubleClick);
            // 
            // txtWednesday
            // 
            this.txtWednesday.AllowDrop = true;
            this.txtWednesday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWednesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWednesday.Location = new System.Drawing.Point(623, 77);
            this.txtWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtWednesday.Name = "txtWednesday";
            this.txtWednesday.Size = new System.Drawing.Size(196, 18);
            this.txtWednesday.TabIndex = 17;
            this.txtWednesday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtWednesday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtWednesday.DoubleClick += new System.EventHandler(this.GenericLabelDoubleClick);
            // 
            // txtThursday
            // 
            this.txtThursday.AllowDrop = true;
            this.txtThursday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtThursday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThursday.Location = new System.Drawing.Point(623, 110);
            this.txtThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtThursday.Name = "txtThursday";
            this.txtThursday.Size = new System.Drawing.Size(196, 18);
            this.txtThursday.TabIndex = 18;
            this.txtThursday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtThursday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtThursday.DoubleClick += new System.EventHandler(this.GenericLabelDoubleClick);
            // 
            // txtFriday
            // 
            this.txtFriday.AllowDrop = true;
            this.txtFriday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFriday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriday.Location = new System.Drawing.Point(623, 144);
            this.txtFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtFriday.Name = "txtFriday";
            this.txtFriday.Size = new System.Drawing.Size(196, 18);
            this.txtFriday.TabIndex = 19;
            this.txtFriday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtFriday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtFriday.DoubleClick += new System.EventHandler(this.GenericLabelDoubleClick);
            // 
            // txtSaturday
            // 
            this.txtSaturday.AllowDrop = true;
            this.txtSaturday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSaturday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaturday.Location = new System.Drawing.Point(623, 175);
            this.txtSaturday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSaturday.Name = "txtSaturday";
            this.txtSaturday.Size = new System.Drawing.Size(196, 18);
            this.txtSaturday.TabIndex = 20;
            this.txtSaturday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtSaturday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtSaturday.DoubleClick += new System.EventHandler(this.GenericLabelDoubleClick);
            // 
            // txtSunday
            // 
            this.txtSunday.AllowDrop = true;
            this.txtSunday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSunday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSunday.Location = new System.Drawing.Point(623, 207);
            this.txtSunday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSunday.Name = "txtSunday";
            this.txtSunday.Size = new System.Drawing.Size(196, 18);
            this.txtSunday.TabIndex = 21;
            this.txtSunday.DragDrop += new System.Windows.Forms.DragEventHandler(this.GenericDragDrop);
            this.txtSunday.DragEnter += new System.Windows.Forms.DragEventHandler(this.GenericDragEnter);
            this.txtSunday.DoubleClick += new System.EventHandler(this.GenericLabelDoubleClick);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(623, 255);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(193, 44);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept this plan";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(291, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Meal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 229);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_MouseDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(407, 256);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 44);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSuggest
            // 
            this.btnSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuggest.Location = new System.Drawing.Point(514, 256);
            this.btnSuggest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(95, 44);
            this.btnSuggest.TabIndex = 23;
            this.btnSuggest.Text = "Suggest";
            this.btnSuggest.UseVisualStyleBackColor = true;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 311);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Plan";
            this.Text = "Plan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Plan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSuggest;
    }
}