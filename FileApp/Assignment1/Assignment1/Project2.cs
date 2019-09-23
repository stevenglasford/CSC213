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
    public partial class Project2 : Form
    {
        public Project2()
        {
            InitializeComponent();
        }

        private void Project2_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        StreamReader inFile;
        //the master key of the data
        List<char> MASTER_KEY = new List<char>(
            new char[] { 'B', 'D', 'A', 'A', 'C',
                    'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A',
                    'D', 'C', 'C', 'B', 'D', 'A' });



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //clear the listbox before anything, making sure the data
                //is precise
                listBox1.Items.Clear();
                int correct = 0;
                inFile = File.OpenText(openFileDialog1.FileName);

                List<char> myList = new List<char>();

                while (!inFile.EndOfStream)
                {
                    string lineRead = inFile.ReadLine();
                    //try to read in the data from the file, will not 
                    //add to the list if the data is wrong
                    if (char.TryParse(lineRead, out char result))
                    {
                        myList.Add(result);
                    }
                }
                inFile.Close();

                //using an anonymous function zip the two files together
                //then add to a new list where it stores a the places where the 
                //student got a wrong answer
                var correctAnswers = myList.Zip(MASTER_KEY, (a, b) => a == b);
                for (int i = 0; i < correctAnswers.Count(); i++)
                {
                    if (!correctAnswers.ElementAt(i))
                    {
                        listBox1.Items.Add(i + 1);
                    }
                    else
                    {
                        correct++;
                    }
                }

                //output the data
                totalCorrect.Text = correct.ToString();
                incorrectLabel.Text = (20 - correct).ToString();
                if (correct > (20 - 5))
                {
                    MessageBox.Show("Congrats you passed");
                }
                else
                {
                    MessageBox.Show("You failed loser");
                }
            }
        }
    }
}
