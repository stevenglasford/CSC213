using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aug27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string first = firstName.Text;
            string last = lastName.Text;
            resultLabel.Text = first + " " + last;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstName.Clear();
            lastName.Text = "";
            resultLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
