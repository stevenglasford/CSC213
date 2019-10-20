namespace Assignment2
{
    partial class Project3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populationDBDataSet = new Assignment2.PopulationDBDataSet();
            this.cityTableAdapter = new Assignment2.PopulationDBDataSetTableAdapters.CityTableAdapter();
            this.SortingBox = new System.Windows.Forms.GroupBox();
            this.CityNameButton = new System.Windows.Forms.Button();
            this.PopulationDescendingButton = new System.Windows.Forms.Button();
            this.PopulationAscendingButton = new System.Windows.Forms.Button();
            this.TotalPopButton = new System.Windows.Forms.Button();
            this.StatisticsGroup = new System.Windows.Forms.GroupBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.LowPopButton = new System.Windows.Forms.Button();
            this.HighPopButton = new System.Windows.Forms.Button();
            this.AvgPopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).BeginInit();
            this.SortingBox.SuspendLayout();
            this.StatisticsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.populationDBDataSet;
            // 
            // populationDBDataSet
            // 
            this.populationDBDataSet.DataSetName = "PopulationDBDataSet";
            this.populationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // SortingBox
            // 
            this.SortingBox.Controls.Add(this.CityNameButton);
            this.SortingBox.Controls.Add(this.PopulationDescendingButton);
            this.SortingBox.Controls.Add(this.PopulationAscendingButton);
            this.SortingBox.Location = new System.Drawing.Point(348, 22);
            this.SortingBox.Name = "SortingBox";
            this.SortingBox.Size = new System.Drawing.Size(214, 170);
            this.SortingBox.TabIndex = 1;
            this.SortingBox.TabStop = false;
            this.SortingBox.Text = "Sort Cities By ...";
            this.SortingBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // CityNameButton
            // 
            this.CityNameButton.Location = new System.Drawing.Point(14, 125);
            this.CityNameButton.Name = "CityNameButton";
            this.CityNameButton.Size = new System.Drawing.Size(189, 30);
            this.CityNameButton.TabIndex = 2;
            this.CityNameButton.Text = "Name";
            this.CityNameButton.UseVisualStyleBackColor = true;
            // 
            // PopulationDescendingButton
            // 
            this.PopulationDescendingButton.Location = new System.Drawing.Point(14, 78);
            this.PopulationDescendingButton.Name = "PopulationDescendingButton";
            this.PopulationDescendingButton.Size = new System.Drawing.Size(189, 30);
            this.PopulationDescendingButton.TabIndex = 1;
            this.PopulationDescendingButton.Text = "Population in Descending Order";
            this.PopulationDescendingButton.UseVisualStyleBackColor = true;
            // 
            // PopulationAscendingButton
            // 
            this.PopulationAscendingButton.Location = new System.Drawing.Point(14, 27);
            this.PopulationAscendingButton.Name = "PopulationAscendingButton";
            this.PopulationAscendingButton.Size = new System.Drawing.Size(189, 30);
            this.PopulationAscendingButton.TabIndex = 0;
            this.PopulationAscendingButton.Text = "Population in Ascending Order";
            this.PopulationAscendingButton.UseVisualStyleBackColor = true;
            this.PopulationAscendingButton.Click += new System.EventHandler(this.PopulationAscendingButton_Click);
            // 
            // TotalPopButton
            // 
            this.TotalPopButton.Location = new System.Drawing.Point(6, 19);
            this.TotalPopButton.Name = "TotalPopButton";
            this.TotalPopButton.Size = new System.Drawing.Size(107, 64);
            this.TotalPopButton.TabIndex = 2;
            this.TotalPopButton.Text = "Total Population";
            this.TotalPopButton.UseVisualStyleBackColor = true;
            this.TotalPopButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // StatisticsGroup
            // 
            this.StatisticsGroup.Controls.Add(this.AnswerLabel);
            this.StatisticsGroup.Controls.Add(this.LowPopButton);
            this.StatisticsGroup.Controls.Add(this.HighPopButton);
            this.StatisticsGroup.Controls.Add(this.AvgPopButton);
            this.StatisticsGroup.Controls.Add(this.TotalPopButton);
            this.StatisticsGroup.Location = new System.Drawing.Point(40, 197);
            this.StatisticsGroup.Name = "StatisticsGroup";
            this.StatisticsGroup.Size = new System.Drawing.Size(270, 211);
            this.StatisticsGroup.TabIndex = 3;
            this.StatisticsGroup.TabStop = false;
            this.StatisticsGroup.Text = "Statistics";
            this.StatisticsGroup.Enter += new System.EventHandler(this.StatisticsGroup_Enter);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(43, 179);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(48, 13);
            this.AnswerLabel.TabIndex = 6;
            this.AnswerLabel.Text = "Answer: ";
            this.AnswerLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LowPopButton
            // 
            this.LowPopButton.Location = new System.Drawing.Point(146, 98);
            this.LowPopButton.Name = "LowPopButton";
            this.LowPopButton.Size = new System.Drawing.Size(107, 64);
            this.LowPopButton.TabIndex = 5;
            this.LowPopButton.Text = "button4";
            this.LowPopButton.UseVisualStyleBackColor = true;
            this.LowPopButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // HighPopButton
            // 
            this.HighPopButton.Location = new System.Drawing.Point(6, 98);
            this.HighPopButton.Name = "HighPopButton";
            this.HighPopButton.Size = new System.Drawing.Size(107, 64);
            this.HighPopButton.TabIndex = 4;
            this.HighPopButton.Text = "Highest Population";
            this.HighPopButton.UseVisualStyleBackColor = true;
            // 
            // AvgPopButton
            // 
            this.AvgPopButton.Location = new System.Drawing.Point(146, 19);
            this.AvgPopButton.Name = "AvgPopButton";
            this.AvgPopButton.Size = new System.Drawing.Size(107, 64);
            this.AvgPopButton.TabIndex = 3;
            this.AvgPopButton.Text = "Average Population";
            this.AvgPopButton.UseVisualStyleBackColor = true;
            this.AvgPopButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Project3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatisticsGroup);
            this.Controls.Add(this.SortingBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Project3";
            this.Text = "Project3";
            this.Load += new System.EventHandler(this.Project2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).EndInit();
            this.SortingBox.ResumeLayout(false);
            this.StatisticsGroup.ResumeLayout(false);
            this.StatisticsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PopulationDBDataSet populationDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox SortingBox;
        private System.Windows.Forms.Button CityNameButton;
        private System.Windows.Forms.Button PopulationDescendingButton;
        private System.Windows.Forms.Button PopulationAscendingButton;
        private System.Windows.Forms.Button TotalPopButton;
        private System.Windows.Forms.GroupBox StatisticsGroup;
        private System.Windows.Forms.Button LowPopButton;
        private System.Windows.Forms.Button HighPopButton;
        private System.Windows.Forms.Button AvgPopButton;
        private System.Windows.Forms.Label AnswerLabel;
    }
}

