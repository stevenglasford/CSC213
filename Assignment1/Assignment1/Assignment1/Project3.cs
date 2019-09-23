using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment1
{
    public partial class Project3 : Form
    {
        public Project3()
        {
            InitializeComponent();
        }

        private void Project3_Load(object sender, EventArgs e)
        {
            StreamReader inFile;
            int year = 1950;
            int lastPopulation = 0;
            //put the labels on the listBox
            listBox1.Items.Add("Year    Population    Increase");
            //open the file USPopulation
            string fileName = "USPopulation.txt";
            inFile = File.OpenText(fileName);

            //create a list to contain the year, total population,
            //and the increase in the population for the year
            List<(int, int, int)> pop = new List<(int, int, int)>();

            //read the file into the piece of shit
            while (!inFile.EndOfStream)
            {
                string lineRead = inFile.ReadLine();
                if (int.TryParse(lineRead, out int result)){
                    
                    //output the data
                    if (lastPopulation == 0)
                    {
                        pop.Add((year, result, 0));
                        listBox1.Items.Add(string.Format(
                        "{0,4}     {1,6:N0}        {2,5:N0}",
                        year, result, 0));

                    }
                    else
                    {
                        pop.Add((year, result, result - lastPopulation));
                        listBox1.Items.Add(string.Format(
                        "{0,4}     {1,6:N0}        {2,5:N0}",
                        year, result, result - lastPopulation));
                    }
                    
                    lastPopulation = result;
                }
                year++;
            }
            //Close the damn file
            inFile.Close();

            //add the average annual change
            outputData.Text = "The average annual change in population " +
                ((pop.Last().Item2 - pop.First().Item2) / pop.Count());

            //the greatest increase part
            outputData.Text += "\nThe year with the greatest increase is " +
                pop.Select(i => (i.Item3, i.Item1)).Max().Item2;

            //the least increase part
            //remove the first element because 1950 is a population that is 
            pop.Remove(pop.ElementAt(0));
            outputData.Text += "\nThe year with the least increase is " +
                pop.Select(i => (i.Item3, i.Item1)).Min().Item2;


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
