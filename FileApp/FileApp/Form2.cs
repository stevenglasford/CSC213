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

namespace FileApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader inFile;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inFile = File.OpenText(openFileDialog1.FileName);

                List<string> myList = new List<string>();

                while (!inFile.EndOfStream)
                {
                    myList.Add(inFile.ReadLine());
                }
                inFile.Close();
                //show data
                foreach (string x in myList)
                {
                    listBox1.Items.Add(x);
                }
            }
        
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
