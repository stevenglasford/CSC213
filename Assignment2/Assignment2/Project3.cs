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

namespace Assignment2
{
    public partial class Project3 : Form
    {
        public Project3()
        {
            InitializeComponent();
        }

        PopulationDBEntities dbcon = new PopulationDBEntities();
        private void Project2_Load(object sender, EventArgs e)
        {
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.CityName
                         select x;



            dataGridView1.DataSource = dbcon.Cities.Local.ToList();

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PopulationAscendingButton_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void StatisticsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
