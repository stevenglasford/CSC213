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
            this.AnsLabel = new System.Windows.Forms.Label();
            this.HighButton = new System.Windows.Forms.Button();
            this.LowButton = new System.Windows.Forms.Button();
            this.TotalButton = new System.Windows.Forms.Button();
            this.AvgButton = new System.Windows.Forms.Button();
            this.PopNameChangeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PopAddText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddGroup = new System.Windows.Forms.GroupBox();
            this.ShowCityButton = new System.Windows.Forms.Button();
            this.CreateCityButton = new System.Windows.Forms.Button();
            this.NameDeleteText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteCityButton = new System.Windows.Forms.Button();
            this.DeleteGroup = new System.Windows.Forms.GroupBox();
            this.ChangeCityButton = new System.Windows.Forms.Button();
            this.NameOldText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PopChangeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SortGroup.SuspendLayout();
            this.StatsGroup.SuspendLayout();
            this.AddGroup.SuspendLayout();
            this.DeleteGroup.SuspendLayout();
            this.ChangeGroup.SuspendLayout();
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
            // AnsLabel
            // 
            this.AnsLabel.AutoSize = true;
            this.AnsLabel.Location = new System.Drawing.Point(27, 176);
            this.AnsLabel.Name = "AnsLabel";
            this.AnsLabel.Size = new System.Drawing.Size(48, 13);
            this.AnsLabel.TabIndex = 4;
            this.AnsLabel.Text = "Answer: ";
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
            // PopNameChangeText
            // 
            this.PopNameChangeText.Location = new System.Drawing.Point(69, 25);
            this.PopNameChangeText.Name = "PopNameChangeText";
            this.PopNameChangeText.Size = new System.Drawing.Size(120, 20);
            this.PopNameChangeText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PopAddText
            // 
            this.PopAddText.Location = new System.Drawing.Point(69, 51);
            this.PopAddText.Name = "PopAddText";
            this.PopAddText.Size = new System.Drawing.Size(120, 20);
            this.PopAddText.TabIndex = 3;
            this.PopAddText.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Population";
            // 
            // AddGroup
            // 
            this.AddGroup.Controls.Add(this.ShowCityButton);
            this.AddGroup.Controls.Add(this.CreateCityButton);
            this.AddGroup.Controls.Add(this.label2);
            this.AddGroup.Controls.Add(this.PopAddText);
            this.AddGroup.Controls.Add(this.label1);
            this.AddGroup.Controls.Add(this.PopNameChangeText);
            this.AddGroup.Location = new System.Drawing.Point(563, 12);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(195, 109);
            this.AddGroup.TabIndex = 3;
            this.AddGroup.TabStop = false;
            this.AddGroup.Text = "Add a City";
            // 
            // ShowCityButton
            // 
            this.ShowCityButton.Location = new System.Drawing.Point(99, 77);
            this.ShowCityButton.Name = "ShowCityButton";
            this.ShowCityButton.Size = new System.Drawing.Size(84, 26);
            this.ShowCityButton.TabIndex = 7;
            this.ShowCityButton.Text = "Show City";
            this.ShowCityButton.UseVisualStyleBackColor = true;
            this.ShowCityButton.Click += new System.EventHandler(this.ShowCityButton_Click);
            // 
            // CreateCityButton
            // 
            this.CreateCityButton.Location = new System.Drawing.Point(9, 77);
            this.CreateCityButton.Name = "CreateCityButton";
            this.CreateCityButton.Size = new System.Drawing.Size(84, 26);
            this.CreateCityButton.TabIndex = 6;
            this.CreateCityButton.Text = "Create City";
            this.CreateCityButton.UseVisualStyleBackColor = true;
            this.CreateCityButton.Click += new System.EventHandler(this.CreateCityButton_Click_1);
            // 
            // NameDeleteText
            // 
            this.NameDeleteText.Location = new System.Drawing.Point(69, 16);
            this.NameDeleteText.Name = "NameDeleteText";
            this.NameDeleteText.Size = new System.Drawing.Size(120, 20);
            this.NameDeleteText.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // DeleteCityButton
            // 
            this.DeleteCityButton.Location = new System.Drawing.Point(16, 42);
            this.DeleteCityButton.Name = "DeleteCityButton";
            this.DeleteCityButton.Size = new System.Drawing.Size(173, 30);
            this.DeleteCityButton.TabIndex = 2;
            this.DeleteCityButton.Text = "Delete a City";
            this.DeleteCityButton.UseVisualStyleBackColor = true;
            this.DeleteCityButton.Click += new System.EventHandler(this.DeleteCityButton_Click);
            // 
            // DeleteGroup
            // 
            this.DeleteGroup.Controls.Add(this.DeleteCityButton);
            this.DeleteGroup.Controls.Add(this.label5);
            this.DeleteGroup.Controls.Add(this.NameDeleteText);
            this.DeleteGroup.Location = new System.Drawing.Point(563, 276);
            this.DeleteGroup.Name = "DeleteGroup";
            this.DeleteGroup.Size = new System.Drawing.Size(195, 81);
            this.DeleteGroup.TabIndex = 4;
            this.DeleteGroup.TabStop = false;
            this.DeleteGroup.Text = "Delete a City";
            // 
            // ChangeCityButton
            // 
            this.ChangeCityButton.Location = new System.Drawing.Point(23, 109);
            this.ChangeCityButton.Name = "ChangeCityButton";
            this.ChangeCityButton.Size = new System.Drawing.Size(138, 26);
            this.ChangeCityButton.TabIndex = 0;
            this.ChangeCityButton.Text = "Change a City";
            this.ChangeCityButton.UseVisualStyleBackColor = true;
            this.ChangeCityButton.Click += new System.EventHandler(this.ChangeCityButton_Click);
            // 
            // NameOldText
            // 
            this.NameOldText.Location = new System.Drawing.Point(69, 25);
            this.NameOldText.Name = "NameOldText";
            this.NameOldText.Size = new System.Drawing.Size(120, 20);
            this.NameOldText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // PopChangeText
            // 
            this.PopChangeText.Location = new System.Drawing.Point(69, 83);
            this.PopChangeText.Name = "PopChangeText";
            this.PopChangeText.Size = new System.Drawing.Size(120, 20);
            this.PopChangeText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Population";
            // 
            // NewNameText
            // 
            this.NewNameText.Location = new System.Drawing.Point(69, 53);
            this.NewNameText.Name = "NewNameText";
            this.NewNameText.Size = new System.Drawing.Size(120, 20);
            this.NewNameText.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "New Name";
            // 
            // ChangeGroup
            // 
            this.ChangeGroup.Controls.Add(this.label6);
            this.ChangeGroup.Controls.Add(this.NewNameText);
            this.ChangeGroup.Controls.Add(this.label3);
            this.ChangeGroup.Controls.Add(this.PopChangeText);
            this.ChangeGroup.Controls.Add(this.label4);
            this.ChangeGroup.Controls.Add(this.NameOldText);
            this.ChangeGroup.Controls.Add(this.ChangeCityButton);
            this.ChangeGroup.Location = new System.Drawing.Point(563, 129);
            this.ChangeGroup.Name = "ChangeGroup";
            this.ChangeGroup.Size = new System.Drawing.Size(195, 141);
            this.ChangeGroup.TabIndex = 4;
            this.ChangeGroup.TabStop = false;
            this.ChangeGroup.Text = "Change a City";
            // 
            // Project3
            // 
            this.ClientSize = new System.Drawing.Size(787, 369);
            this.Controls.Add(this.ChangeGroup);
            this.Controls.Add(this.DeleteGroup);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.StatsGroup);
            this.Controls.Add(this.SortGroup);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Project3";
            this.Text = "Project 3";
            this.Load += new System.EventHandler(this.Project3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.SortGroup.ResumeLayout(false);
            this.StatsGroup.ResumeLayout(false);
            this.StatsGroup.PerformLayout();
            this.AddGroup.ResumeLayout(false);
            this.AddGroup.PerformLayout();
            this.DeleteGroup.ResumeLayout(false);
            this.DeleteGroup.PerformLayout();
            this.ChangeGroup.ResumeLayout(false);
            this.ChangeGroup.PerformLayout();
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
        private System.Windows.Forms.TextBox PopNameChangeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PopAddText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AddGroup;
        private System.Windows.Forms.TextBox NameDeleteText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteCityButton;
        private System.Windows.Forms.GroupBox DeleteGroup;
        private System.Windows.Forms.Button ChangeCityButton;
        private System.Windows.Forms.TextBox NameOldText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PopChangeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox ChangeGroup;
        private System.Windows.Forms.Button ShowCityButton;
        private System.Windows.Forms.Button CreateCityButton;
    }
}

