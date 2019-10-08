using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacationsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LocationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vacationsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vacationsDataSet.Locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.vacationsDataSet.Locations);

        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            label1.Text = this.locationsTableAdapter.MinDays().ToString();
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            label2.Text = this.locationsTableAdapter.AvgDays().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int dayFrom = Convert.ToInt32(textBox1.Text);
            int dayTo = Convert.ToInt32(textBox2.Text);
            this.locationsTableAdapter.
                FillByDays(this.vacationsDataSet.Locations,dayFrom,dayTo);
        }

        private void AfterDate_Click(object sender, EventArgs e)
        {
            DateTime myDate = Convert.ToDateTime(afterDateTextbox.Text);

            this.locationsTableAdapter.
                FillByDate(this.vacationsDataSet.Locations, myDate);
        }
    }
}
