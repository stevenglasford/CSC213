using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = comboBox1.SelectedValue.ToString();

            dataGridView1.DataSource = this.locationsTableAdapter.GetDataByCountry(con);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vacationsDataSet.Locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.vacationsDataSet.Locations);

        }
    }
}
