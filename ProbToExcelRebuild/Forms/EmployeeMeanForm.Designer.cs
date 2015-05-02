﻿namespace ProbToExcelRebuild.Forms
{
    partial class EmployeeMeanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMeanForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MeanComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.GroupBox();
            this.MeanAssGrid = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstQuartile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Median = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdQuartile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeanAssGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MeanComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate";
            // 
            // MeanComboBox
            // 
            this.MeanComboBox.FormattingEnabled = true;
            this.MeanComboBox.Items.AddRange(new object[] {
            "University",
            "Job Title",
            "Department"});
            this.MeanComboBox.Location = new System.Drawing.Point(89, 29);
            this.MeanComboBox.Name = "MeanComboBox";
            this.MeanComboBox.Size = new System.Drawing.Size(167, 21);
            this.MeanComboBox.TabIndex = 1;
            this.MeanComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Averages of: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(300, 386);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(110, 37);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "Export To Excel";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.MeanAssGrid);
            this.Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(597, 335);
            this.Output.TabIndex = 3;
            this.Output.TabStop = false;
            this.Output.Text = "Output";
            // 
            // MeanAssGrid
            // 
            this.MeanAssGrid.AllowUserToAddRows = false;
            this.MeanAssGrid.AllowUserToDeleteRows = false;
            this.MeanAssGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeanAssGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Mean,
            this.FirstQuartile,
            this.Median,
            this.ThirdQuartile});
            this.MeanAssGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeanAssGrid.Location = new System.Drawing.Point(3, 16);
            this.MeanAssGrid.Name = "MeanAssGrid";
            this.MeanAssGrid.ReadOnly = true;
            this.MeanAssGrid.Size = new System.Drawing.Size(591, 316);
            this.MeanAssGrid.TabIndex = 0;
            this.MeanAssGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MeanAssGrid_CellContentClick);
            // 
            // Property
            // 
            this.Property.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Property.HeaderText = "Property";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            // 
            // Mean
            // 
            this.Mean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mean.HeaderText = "Mean";
            this.Mean.Name = "Mean";
            this.Mean.ReadOnly = true;
            // 
            // FirstQuartile
            // 
            this.FirstQuartile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstQuartile.HeaderText = "1st Quartile";
            this.FirstQuartile.Name = "FirstQuartile";
            this.FirstQuartile.ReadOnly = true;
            // 
            // Median
            // 
            this.Median.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Median.HeaderText = "Median";
            this.Median.Name = "Median";
            this.Median.ReadOnly = true;
            // 
            // ThirdQuartile
            // 
            this.ThirdQuartile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThirdQuartile.HeaderText = "3rd Quartile";
            this.ThirdQuartile.Name = "ThirdQuartile";
            this.ThirdQuartile.ReadOnly = true;
            // 
            // EmployeeMeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 465);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeMeanForm";
            this.Text = "Average Salaries";
            this.Load += new System.EventHandler(this.EmployeeMeanForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MeanAssGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MeanComboBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.DataGridView MeanAssGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstQuartile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Median;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdQuartile;
    }
}