using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept5App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int number = 5;
            listBox1.Items.Add(ShowSum(number).ToString());
            listBox1.Items.Add("number byVal : " + number);

            // by Ref
            listBox1.Items.Add(ShowSumByRef(ref number).ToString());
            listBox1.Items.Add("number byRef : " + number);
            //by out
            int number2;
            int x = AddData(out number2);
            listBox1.Items.Add("number byOut : " + number2);


        }

        private int AddData(out int x)
        {
            x = 22;
            return x;
        }

        //By val
        private int ShowSum(int num)
        {
            num += 5;
            int result = num + 10;
            return result;
        }

        //By ref
        private int ShowSumByRef(ref int num)
        {
            num += 5;
            int result = num + 10;
            return result;
        }

    }
}
