using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //added stuff to the array thing
            RetailItem[] stuff = new RetailItem[3];
            stuff[0] = new RetailItem("Jacket", 12, 59.95M);
            stuff[1] = new RetailItem("Jeans", 40, 34.95M);
            stuff[2] = new RetailItem("Shirt", 20, 24.95M);
        }
    }
}
