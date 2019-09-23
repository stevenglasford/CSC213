namespace Aug27
{
    partial class Form1
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
            this.poopShit = new System.Windows.Forms.Label();
            this.vagina = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poopShit
            // 
            this.poopShit.AutoSize = true;
            this.poopShit.Location = new System.Drawing.Point(135, 52);
            this.poopShit.Name = "poopShit";
            this.poopShit.Size = new System.Drawing.Size(57, 13);
            this.poopShit.TabIndex = 0;
            this.poopShit.Text = "First Name";
            this.poopShit.Click += new System.EventHandler(this.Label1_Click);
            // 
            // vagina
            // 
            this.vagina.AutoSize = true;
            this.vagina.Location = new System.Drawing.Point(135, 94);
            this.vagina.Name = "vagina";
            this.vagina.Size = new System.Drawing.Size(58, 13);
            this.vagina.TabIndex = 1;
            this.vagina.Text = "Last Name";
            this.vagina.Click += new System.EventHandler(this.Label2_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(225, 45);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(347, 20);
            this.firstName.TabIndex = 2;
            this.firstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(225, 94);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(347, 20);
            this.lastName.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 199);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(157, 63);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(320, 199);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(157, 63);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(631, 199);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 63);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.resultLabel.Location = new System.Drawing.Point(102, 303);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(621, 105);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.vagina);
            this.Controls.Add(this.poopShit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poopShit;
        private System.Windows.Forms.Label vagina;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

