using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Invoice> myInvoices = new List<Invoice>();

        private void Form1_Load(object sender, EventArgs e)
        {
            myInvoices.Add(new Invoice(111, "aaa", 4, 56));
            myInvoices.Add(new Invoice(333,"abb", 5, 64));
            myInvoices.Add(new Invoice(222, "cccc", 6, 35));
            myInvoices.Add(new Invoice(444, "ddd", 7, 67));
            myInvoices.Add(new Invoice(555, "eee", 8, 11));
            //show the data from the list in the dataDridView1
            //dataGridView1.DataSource = myInvoices;

            var result =
                from x in myInvoices
                orderby x.PartDescription
                select x;

            dataGridView1.DataSource = result.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int partNum = Convert.ToInt32(textBox1.Text);

            Invoice partInfo =
                (from x in myInvoices
                where x.PartNumber == partNum
                select x).First();

            //putput
            listBox1.Items.Add(partInfo.PartNumber);
            listBox1.Items.Add(partInfo.PartDescription);
            listBox1.Items.Add(partInfo.Quantity);
            listBox1.Items.Add(partInfo.Price);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string partName = textBox1.Text;

            Invoice partInfo =
                (from x in myInvoices
                 where x.PartDescription.StartsWith(partName)
                 select x).First();

            //putput
            listBox1.Items.Add(partInfo.PartNumber);
            listBox1.Items.Add(partInfo.PartDescription);
            listBox1.Items.Add(partInfo.Quantity);
            listBox1.Items.Add(partInfo.Price);
        }
    }
}
