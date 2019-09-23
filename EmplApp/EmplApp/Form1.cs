using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmplApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BasePlusCommissionEmployee myEmp =
                new BasePlusCommissionEmployee("aaa", "bb", "123", 540.00M,
                0.3M, 30000.0M);
            listBox1.Items.Add(myEmp);
            listBox1.Items.Add(myEmp.Earnings());
        }
    }
}
