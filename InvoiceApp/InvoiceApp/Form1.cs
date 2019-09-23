using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceApp
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
            myInvoices.Add(new Invoice(1111, "BBB", 6, 30.2m));
            myInvoices.Add(new Invoice(1111, "AAA", 3, 130.2m));
            myInvoices.Add(new Invoice(1111, "NNN", 6, 20.2m));
            myInvoices.Add(new Invoice(1111, "ABC", 6, 80.2m));
            myInvoices.Add(new Invoice(1111, "MJU", 10, 10.2m));
            myInvoices.Add(new Invoice(1111, "NSF", 6, 30.2m));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //D
            var totalSET =
                from el in myInvoices
                let totalTEMP = el.Quantity * el.Price
                select new { el.PartDescription, InvoiceTotal = totalTEMP };

            //0utput
            foreach (var x in totalSET)
                listBox1.Items.Add(x.PartDescription + "Total = "
                    + x.InvoiceTotal.ToString("c"));

            //E
            listBox1.Items.Add("-----------E-----------");

            var total200AND500 =
                from zz in totalSET
                where zz.InvoiceTotal >= 200.0m && zz.InvoiceTotal <= 500.0m
                select zz;
            foreach (var x in totalSET)
                listBox1.Items.Add(x.PartDescription + "Total >= 200 AND <= 500 "
                    + x.InvoiceTotal.ToString("c"));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var sortedStuff =
                from el in myInvoices
                orderby el.PartDescription
                select el;

            foreach (var x in sortedStuff)
                listBox1.Items.Add(x.PartDescription + x.Price);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var sortedStuff =
                from el in myInvoices
                orderby el.Price
                select el;

            foreach (var x in sortedStuff)
                listBox1.Items.Add(x.PartDescription + " "+ x.Price.ToString("c"));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var sortedStuff =
                from el in myInvoices
                orderby el.Quantity
                select new { el.PartDescription, el.Quantity };

            foreach (var x in sortedStuff)
                listBox1.Items.Add(x.PartDescription + " " + x.Quantity);
        }
    }
}
