using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AddressBookEntities dbcon = new AddressBookEntities();

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            //Add data to the dbcon
            dbcon.Addresses.Load();

            var result = from x in dbcon.Addresses.Local
                         orderby x.LastName
                         select x;

            //show data in the gridview
            dataGridView1.DataSource = result.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Add data to the dbcon
            dbcon.Addresses.Load();

            var result = from x in dbcon.Addresses.Local
                         where x.LastName.Trim().
                         Equals(textBox1.Text.Trim())
                         orderby x.LastName
                         select x;

            //show data in the gridview
            dataGridView1.DataSource = result.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Address myAddress = new Address();
            myAddress.FirstName = textBox2.Text;
            myAddress.LastName = textBox3.Text;
            myAddress.Email = textBox4.Text;
            myAddress.PhoneNumber = textBox5.Text;

            //add data to the table
            dbcon.Addresses.Add(myAddress);
            dbcon.SaveChanges();

            //show new data in the GridView
            ShowData();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Add data to the dbcon
            dbcon.Addresses.Load();

            var result = from x in dbcon.Addresses.Local
                         where x.AddressID==Convert.ToInt32(textBox6.Text)
                         orderby x.LastName
                         select x;

            //show data in the gridview
            dataGridView1.DataSource = result.ToList();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Add data to the dbcon
            dbcon.Addresses.Load();

            Address result = (from x in dbcon.Addresses.Local
                              where x.AddressID == Convert.ToInt32(textBox6.Text)
                              orderby x.LastName
                              select x).First();

            //Delete object/row from the table
            dbcon.Addresses.Remove(result);
            //show the new table
            ShowData();
        }
    }
}
