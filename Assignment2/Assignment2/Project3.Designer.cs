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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SortGroup = new System.Windows.Forms.GroupBox();
            this.PopNameButton = new System.Windows.Forms.Button();
            this.PopDescendingButton = new System.Windows.Forms.Button();
            this.PopAscendingButton = new System.Windows.Forms.Button();
            this.StatsGroup = new System.Windows.Forms.GroupBox();
            this.HighButton = new System.Windows.Forms.Button();
            this.LowButton = new System.Windows.Forms.Button();
            this.TotalButton = new System.Windows.Forms.Button();
            this.AvgButton = new System.Windows.Forms.Button();
            this.AnsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SortGroup.SuspendLayout();
            this.StatsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 345);
            this.dataGridView2.TabIndex = 0;
            // 
            // SortGroup
            // 
            this.SortGroup.Controls.Add(this.PopNameButton);
            this.SortGroup.Controls.Add(this.PopDescendingButton);
            this.SortGroup.Controls.Add(this.PopAscendingButton);
            this.SortGroup.Location = new System.Drawing.Point(325, 12);
            this.SortGroup.Name = "SortGroup";
            this.SortGroup.Size = new System.Drawing.Size(210, 109);
            this.SortGroup.TabIndex = 1;
            this.SortGroup.TabStop = false;
            this.SortGroup.Text = "Sort By";
            // 
            // PopNameButton
            // 
            this.PopNameButton.Location = new System.Drawing.Point(16, 72);
            this.PopNameButton.Name = "PopNameButton";
            this.PopNameButton.Size = new System.Drawing.Size(188, 22);
            this.PopNameButton.TabIndex = 2;
            this.PopNameButton.Text = "Population Name";
            this.PopNameButton.UseVisualStyleBackColor = true;
            this.PopNameButton.Click += new System.EventHandler(this.PopNameButton_Click);
            // 
            // PopDescendingButton
            // 
            this.PopDescendingButton.Location = new System.Drawing.Point(16, 44);
            this.PopDescendingButton.Name = "PopDescendingButton";
            this.PopDescendingButton.Size = new System.Drawing.Size(188, 22);
            this.PopDescendingButton.TabIndex = 1;
            this.PopDescendingButton.Text = "Population Descending";
            this.PopDescendingButton.UseVisualStyleBackColor = true;
            this.PopDescendingButton.Click += new System.EventHandler(this.PopDescendingButton_Click);
            // 
            // PopAscendingButton
            // 
            this.PopAscendingButton.Location = new System.Drawing.Point(15, 16);
            this.PopAscendingButton.Name = "PopAscendingButton";
            this.PopAscendingButton.Size = new System.Drawing.Size(188, 22);
            this.PopAscendingButton.TabIndex = 0;
            this.PopAscendingButton.Text = "Population Ascending";
            this.PopAscendingButton.UseVisualStyleBackColor = true;
            this.PopAscendingButton.Click += new System.EventHandler(this.PopAscendingButton_Click);
            // 
            // StatsGroup
            // 
            this.StatsGroup.Controls.Add(this.AnsLabel);
            this.StatsGroup.Controls.Add(this.HighButton);
            this.StatsGroup.Controls.Add(this.LowButton);
            this.StatsGroup.Controls.Add(this.TotalButton);
            this.StatsGroup.Controls.Add(this.AvgButton);
            this.StatsGroup.Location = new System.Drawing.Point(324, 127);
            this.StatsGroup.Name = "StatsGroup";
            this.StatsGroup.Size = new System.Drawing.Size(215, 230);
            this.StatsGroup.TabIndex = 2;
            this.StatsGroup.TabStop = false;
            this.StatsGroup.Text = "Statistics";
            // 
            // HighButton
            // 
            this.HighButton.Location = new System.Drawing.Point(16, 130);
            this.HighButton.Name = "HighButton";
            this.HighButton.Size = new System.Drawing.Size(176, 28);
            this.HighButton.TabIndex = 3;
            this.HighButton.Text = "Highest Population";
            this.HighButton.UseVisualStyleBackColor = true;
            this.HighButton.Click += new System.EventHandler(this.HighButton_Click);
            // 
            // LowButton
            // 
            this.LowButton.Location = new System.Drawing.Point(17, 96);
            this.LowButton.Name = "LowButton";
            this.LowButton.Size = new System.Drawing.Size(176, 28);
            this.LowButton.TabIndex = 2;
            this.LowButton.Text = "Lowest Population";
            this.LowButton.UseVisualStyleBackColor = true;
            this.LowButton.Click += new System.EventHandler(this.LowButton_Click);
            // 
            // TotalButton
            // 
            this.TotalButton.Location = new System.Drawing.Point(17, 62);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(176, 28);
            this.TotalButton.TabIndex = 1;
            this.TotalButton.Text = "Total Population";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // AvgButton
            // 
            this.AvgButton.Location = new System.Drawing.Point(17, 28);
            this.AvgButton.Name = "AvgButton";
            this.AvgButton.Size = new System.Drawing.Size(176, 28);
            this.AvgButton.TabIndex = 0;
            this.AvgButton.Text = "Average Population";
            this.AvgButton.UseVisualStyleBackColor = true;
            this.AvgButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AnsLabel
            // 
            this.AnsLabel.AutoSize = true;
            this.AnsLabel.Location = new System.Drawing.Point(27, 176);
            this.AnsLabel.Name = "AnsLabel";
            this.AnsLabel.Size = new System.Drawing.Size(48, 13);
            this.AnsLabel.TabIndex = 4;
            this.AnsLabel.Text = "Answer: ";
            // 
            // Project3
            // 
            this.ClientSize = new System.Drawing.Size(550, 369);
            this.Controls.Add(this.StatsGroup);
            this.Controls.Add(this.SortGroup);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Project3";
            this.Load += new System.EventHandler(this.Project3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.SortGroup.ResumeLayout(false);
            this.StatsGroup.ResumeLayout(false);
            this.StatsGroup.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox SortGroup;
        private System.Windows.Forms.GroupBox StatsGroup;
        private System.Windows.Forms.Button AvgButton;
        private System.Windows.Forms.Button PopNameButton;
        private System.Windows.Forms.Button PopDescendingButton;
        private System.Windows.Forms.Button PopAscendingButton;
        private System.Windows.Forms.Button HighButton;
        private System.Windows.Forms.Button LowButton;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Label AnsLabel;
    }
}

