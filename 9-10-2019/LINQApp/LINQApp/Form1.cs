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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InvoiceList.myInvoices.Add(new Invoice(111, "BBB", 22, 30.00M));
            InvoiceList.myInvoices.Add(new Invoice(333, "aaa", 1, 10.00M));
            InvoiceList.myInvoices.Add(new Invoice(5555, "zzz", 5, 15.00M));
            InvoiceList.myInvoices.Add(new Invoice(6666, "hhh", 32, 50.00M));
            InvoiceList.myInvoices.Add(new Invoice(7777, "eee", 2, 25.00M));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var sortInv =
                from el in InvoiceList.myInvoices
                orderby el.PartDescription
                select el;

            foreach (var item in sortInv)
            {
                listBox1.Items.Add(item.ToString());
            }

            //LINQ 2
            listBox1.Items.Add("_______________________________");
            var qtyInv =
                from item in InvoiceList.myInvoices
                where item.Quantity >= 5
                select item;

            foreach (var item in qtyInv)
            {
                listBox1.Items.Add(item.ToString());
            }

            //LINQ 3
            listBox1.Items.Add("_______________________________");

            var price20To40 =
            from el in InvoiceList.myInvoices
            where el.Price >= 20m && el.Price <= 40m
            select el;

            foreach (var item in price20To40)
            {
                listBox1.Items.Add(item.ToString());
            }

            //LINQ 4
            listBox1.Items.Add("_______________________________");
            var myObj =
                from el in InvoiceList.myInvoices
                select new { el.PartDescription, el.Price };

            foreach (var item in myObj)
            {
                listBox1.Items.Add(item.ToString());
            }
            listBox1.Items.Add("_________________________");
            foreach (var item in myObj)
            {
                listBox1.Items.Add(item.PartDescription + " " +
                    item.Price);
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            Hide();
            myForm.Show();
        }
    }
}
