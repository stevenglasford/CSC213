using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoCares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 
            //'studentDBaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.studentDBaseDataSet.StudentTable);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stID = Convert.ToInt32(comboBox1.SelectedValue);
            //add data to the GridView
            dataGridView1.DataSource = this.studentTableTableAdapter.GetDataByStudentID(stID);

            //first name
            label1.Text = this.studentTableTableAdapter.GetDataByStudentID(stID).First()[1].ToString();
            //Last Name
            label2.Text = this.studentTableTableAdapter.GetDataByStudentID(stID).First()[2].ToString();
            //GPA
            label3.Text = this.studentTableTableAdapter.GetDataByStudentID(stID).First()[3].ToString();
        }
    }
}
