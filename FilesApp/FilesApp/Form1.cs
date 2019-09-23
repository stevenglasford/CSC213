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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outFile;
                outFile = File.AppendText("abc.txt");
                //add data to the text file
                outFile.WriteLine(nameTextBox.Text);
                outFile.WriteLine(gradeTextBox.Text);

                outFile.Close();
                nameTextBox.Clear();
                gradeTextBox.Clear();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.ShowDialog();
        }

        private void ShowForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();
            myForm3.ShowDialog();
        }
    }
}
