using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Project4 : Form
    {
        public Project4()
        {
            InitializeComponent();
        }

        private void Project4_Load(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void AddGroup1_Enter(object sender, EventArgs e)
        {
        }



        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopAscendingButton1_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopAscending(this.populationDBDataSet.City);
        }

        private void PopDescendingButton1_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopDescending(this.populationDBDataSet.City);
        }

        private void PopNameButton1_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByName(this.populationDBDataSet.City);
        }
        private void AvgButton1_Click(object sender, EventArgs e)
        {
            AnsLabel1.Text = "Answer: " + this.cityTableAdapter.AvgPop().ToString();
        }

        private void TotalButton1_Click(object sender, EventArgs e)
        {
            AnsLabel1.Text = "Answer: " + this.cityTableAdapter.TotalPop().ToString();
        }

        private void LowButton1_Click(object sender, EventArgs e)
        {
            AnsLabel1.Text = "Answer: " + this.cityTableAdapter.MinPop().ToString();
        }

        private void HighButton1_Click(object sender, EventArgs e)
        {
            AnsLabel1.Text = "Answer: " + this.cityTableAdapter.MaxPop().ToString();
        }

        private void ShowCityButton1_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillBySearchCity(this.populationDBDataSet.City,
                PopNameChangeText1.Text);
        }

        private void CreateCityButton1_Click(object sender, EventArgs e)
        {
            //insert a new city
            this.cityTableAdapter.InsertCity(PopNameChangeText1.Text, 
                Convert.ToInt32(PopAddText1.Text));
            //display the cities once more
            this.cityTableAdapter.FillByName(this.populationDBDataSet.City);
        }

        private void DeleteCityButton1_Click(object sender, EventArgs e)
        {
            //Delete a city
            this.cityTableAdapter.DeleteCity(NameDeleteText1.Text);
            //display the cities once more
            this.cityTableAdapter.FillByName(this.populationDBDataSet.City);
        }

        private void ChangeCityButton1_Click(object sender, EventArgs e)
        {
            //update the city
            this.cityTableAdapter.UpdateCity(NewNameText1.Text, 
                Convert.ToInt32(PopChangeText1.Text), NameOldText1.Text);
            //display update
            this.cityTableAdapter.FillByName(this.populationDBDataSet.City);
        }
    }
}
