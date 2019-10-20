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

        StudentDataBaseEntities dbcon = new StudentDataBaseEntities();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dbcon.StudentTables.Load();
            dataGridView1.DataSource = dbcon.StudentTables.Local.ToList();
        }
    }
}
