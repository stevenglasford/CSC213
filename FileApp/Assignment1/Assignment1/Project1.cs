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
    public partial class Project1 : Form
    {
        public Project1()
        {
            InitializeComponent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader inFile;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inFile = File.OpenText(openFileDialog1.FileName);

                List<decimal> myList = new List<decimal>();

                while (!inFile.EndOfStream)
                {
                    string lineRead = inFile.ReadLine();
                    if (decimal.TryParse(lineRead, out decimal result))
                    {
                        myList.Add(result);
                    }
                    //yList.Add(inFile.ReadLine());
                }
                inFile.Close();
                //show data from the file
                foreach (decimal x in myList)
                {
                    listBox1.Items.Add(x);
                }
                //show the total, average, max, and min of the values
                //calculate the stuff
                maxLabel.Text = myList.Max().ToString();
                averageLabel.Text = myList.Average().ToString();
                minLabel.Text = myList.Min().ToString();
                totalLabel.Text = myList.Sum().ToString();
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
