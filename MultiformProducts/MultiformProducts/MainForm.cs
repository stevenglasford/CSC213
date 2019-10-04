using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiformProducts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the DetailsForm
            DetailsForm details = new DetailsForm();

            //Display the form 
            details.ShowDialog();

            //Update the dataset
            this.productTableAdapter.Fill(this.productDataSet.Product);
        }
    }
}
