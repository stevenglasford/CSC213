using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksApp
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void AuthorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Authors' table. You can move, or remove it, as needed.
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            //show all of the data
            this.authorsTableAdapter.Fill(this.booksDataSet.Authors);
        }
    }
}
