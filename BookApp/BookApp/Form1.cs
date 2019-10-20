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

namespace BookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BooksEntities dbcon = new BooksEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            //add data  to the DBcon
            dbcon.Authors.Load();

            //work with Data
            var result = from x in dbcon.Authors.Local
                         orderby x.LastName
                         select x;
            //add result to the DataGridview
            dataGridView1.DataSource = result.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //add data  to the DBcon
            dbcon.Authors.Load();

            //work with Data
            var result = from x in dbcon.Authors.Local
                         where x.LastName.StartsWith(textBox1.Text)
                         orderby x.LastName
                         select x;
            //add result to the DataGridview
            dataGridView1.DataSource = result.ToList();
        }
    }
}
