using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = this.studentTableTableAdapter.AvgGPA().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = this.studentTableTableAdapter.MinGPA().ToString();
        }

        private void StudentTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.studentDBDataSet.StudentTable);

        }
    }
}
