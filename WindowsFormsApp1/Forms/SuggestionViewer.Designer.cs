﻿namespace MealPlannerApp.Forms
{
    partial class SuggestionViewer
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.cntFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnResuggest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(12, 9);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(60, 24);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "label1";
            // 
            // cntFlow
            // 
            this.cntFlow.AutoScroll = true;
            this.cntFlow.Location = new System.Drawing.Point(16, 120);
            this.cntFlow.Name = "cntFlow";
            this.cntFlow.Size = new System.Drawing.Size(452, 238);
            this.cntFlow.TabIndex = 1;
            // 
            // btnResuggest
            // 
            this.btnResuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResuggest.Location = new System.Drawing.Point(335, 69);
            this.btnResuggest.Name = "btnResuggest";
            this.btnResuggest.Size = new System.Drawing.Size(134, 45);
            this.btnResuggest.TabIndex = 2;
            this.btnResuggest.Text = "Try again";
            this.btnResuggest.UseVisualStyleBackColor = true;
            this.btnResuggest.Click += new System.EventHandler(this.btnResuggest_Click);
            // 
            // SuggestionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 370);
            this.Controls.Add(this.btnResuggest);
            this.Controls.Add(this.cntFlow);
            this.Controls.Add(this.lblLabel);
            this.Name = "SuggestionViewer";
            this.Text = "Suggested Meals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuggestionViewer_FormClosing);
            this.Load += new System.EventHandler(this.SuggestionViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.FlowLayoutPanel cntFlow;
        private System.Windows.Forms.Button btnResuggest;
    }
}