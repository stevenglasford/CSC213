﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the DetailsForm
            DetailsForm details = new DetailsForm();

            //display the form
            details.ShowDialog();

            //Update the dataset
            this.productTableAdapter.Fill(this.productDataSet.Product);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}