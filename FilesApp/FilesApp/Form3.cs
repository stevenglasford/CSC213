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

namespace FilesApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                double grade;
                StreamReader inFile;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    inFile = File.OpenText(openFileDialog1.FileName);

                    while (!inFile.EndOfStream)
                    {
                        name = inFile.ReadLine();
                        grade = Convert.ToDouble(inFile.ReadLine());
                        //add data to the listbox
                        listBox1.Items.Add(name + " " + grade);
                    }
                    inFile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
