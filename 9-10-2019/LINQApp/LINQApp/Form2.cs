using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Invoice item in InvoiceList.myInvoices)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();

            myForm.ShowLine(listBox1.SelectedItem.ToString());
            Hide();
            myForm.Show();
        }
    }
}
