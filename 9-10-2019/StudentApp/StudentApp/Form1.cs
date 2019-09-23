using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Student myStudent = new Student();
            myStudent.FirstName = "John";
            myStudent.LastName = "Gafry";
            myStudent.GPA = 4.0;
            listBox1.Items.Add(myStudent);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
