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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter outFile;

            outFile = File.AppendText("abc.txt");

            outFile.WriteLine(textBox1.Text + " " + textBox2.Text);

            outFile.Close();

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
