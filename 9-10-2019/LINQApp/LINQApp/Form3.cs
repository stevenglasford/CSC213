using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void ShowLine(string abc)
        {
            label1.Text = abc;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
