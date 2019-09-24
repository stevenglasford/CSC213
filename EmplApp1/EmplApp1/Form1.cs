using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmplApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Employee> myEmplList = new List<Employee>();

        private void Button1_Click(object sender, EventArgs e)
        {
            HourlyEmployee myHEmpl = new HourlyEmployee(
                "aaa", "bb", "123", 25.0M, 50);
            SalariedEmployee mySalEmpl = new SalariedEmployee(
                "ddd", "bb", "2222", 40000.0M);
            CommissionEmployee myComEmpl =
                new CommissionEmployee("ccc", "cc", "333", 700.0m, 0.5m);
            BasePlusCommissionEmployee myBasePlusEmpl =
                new BasePlusCommissionEmployee("www", "ww", "444",
                700.0m, 0.5m, 80000);

            //add data to the myEmplList
            myEmplList.Add(myHEmpl);
            myEmplList.Add(mySalEmpl);
            myEmplList.Add(myComEmpl);
            myEmplList.Add(myBasePlusEmpl);
        }
    }
}
