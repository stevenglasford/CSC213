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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCityButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowCityButton_Click(object sender, EventArgs e)
        {
            //find the city to show
            var result = from x in dbcon.Cities.Local
                         where x.CityName == PopNameChangeText.Text.ToString()
                         orderby x.CityName
                         select x;
            //show data in the gridview
            dataGridView2.DataSource = result.ToList();
        }

        private void CreateCityButton_Click_1(object sender, EventArgs e)
        {
            City myCity = new City();
            myCity.CityName = PopNameChangeText.Text;
            myCity.Population = Convert.ToInt32(PopAddText.Text);

            //add the data to the table
            dbcon.Cities.Add(myCity);
            dbcon.SaveChanges();

            //show the new data in the gridview
            ShowData();
        }

        private void ShowData()
        {
            //Add data to the dbcon
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.CityName
                         select x;

            //show data in the gridview
            dataGridView2.DataSource = result.ToList();
        }

        private void DeleteCityButton_Click(object sender, EventArgs e)
        {
            //add data ti tge dbcon
            dbcon.Cities.Load();

            //find the city
            City result = (from x in dbcon.Cities.Local
                           where x.CityName == NameDeleteText.Text
                           orderby x.CityName
                           select x).First();

            //delete object/row from the table
            dbcon.Cities.Remove(result);
            //save the changes of the table
            dbcon.SaveChanges();

            //show the data 
            ShowData();
        }

        private void ChangeCityButton_Click(object sender, EventArgs e)
        {
            //add data to the dbcon
            dbcon.Cities.Load();

            City result = (from x in dbcon.Cities.Local
                           where x.CityName == NameOldText.Text
                           orderby x.CityName
                           select x).First();


            City myCity = new City();
            myCity.CityName = NewNameText.Text;
            myCity.Population = Convert.ToInt32(PopChangeText.Text);

            //remove the old city
            dbcon.Cities.Remove(result);
            //add the update of the city
            dbcon.Cities.Add(myCity);

            //save the changes of the table
            dbcon.SaveChanges();

            //show the new data in the gridview
            ShowData();
        }
    }
}
