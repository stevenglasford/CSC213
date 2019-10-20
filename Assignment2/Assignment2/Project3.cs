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

        PopulationDBEntities1 dbcon = new PopulationDBEntities1();
        private void Project3_Load(object sender, EventArgs e)
        {
            dbcon.Cities.Load();
            
            //automatically order by the city name, upon loading
            var result = from x in dbcon.Cities.Local
                         orderby x.CityName
                         select x;

            dataGridView2.DataSource = dbcon.Cities.Local.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AnsLabel.Text = "Answer: " + dbcon.Cities.Average(c => c.Population).ToString() ;
        }

        private void PopAscendingButton_Click(object sender, EventArgs e)
        {
            dbcon.Cities.Load();
            //order by the population
            var result = from x in dbcon.Cities.Local
                         orderby x.Population
                         select x;

            dataGridView2.DataSource = result.ToList();
        }

        private void PopDescendingButton_Click(object sender, EventArgs e)
        {
            dbcon.Cities.Load();
            var result = from x in dbcon.Cities.Local
                         orderby x.Population descending
                         select x;

            dataGridView2.DataSource = result.ToList();
        }

        private void PopNameButton_Click(object sender, EventArgs e)
        {
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.CityName
                         select x;

            dataGridView2.DataSource = dbcon.Cities.Local.ToList();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            AnsLabel.Text = "Answer: " + dbcon.Cities.Sum(c => c.Population).ToString();
        }

        private void LowButton_Click(object sender, EventArgs e)
        {
            AnsLabel.Text = "Answer: " + dbcon.Cities.Min(c => c.Population).ToString();
        }

        private void HighButton_Click(object sender, EventArgs e)
        {
            AnsLabel.Text = "Answer: " + dbcon.Cities.Max(c => c.Population).ToString();
        }
    }
}
