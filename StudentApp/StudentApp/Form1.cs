using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StudentApp
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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        StudentDataBaseEntities dbcon = new StudentDataBaseEntities();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dbcon.StudentTables.Load();
            dataGridView1.DataSource = dbcon.StudentTables.Local.ToList();
        }
    }
}
