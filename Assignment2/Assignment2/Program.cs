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
            //Run Project 3
            Application.Run(new Project3());
            //Run Project 4
            Application.Run(new Project4());

            //added stuff to the array thing
            RetailItem[] stuff = new RetailItem[3];
            stuff[0] = new RetailItem("Jacket", 12, 59.95M);
            stuff[1] = new RetailItem("Jeans", 40, 34.95M);
            stuff[2] = new RetailItem("Shirt", 20, 24.95M);

            //demonstrating customer 2
            //Project 2
            Customer myCustomer = new Customer("Poop",
                "420 Smoking Drive", "6969696969", 13, true);

            PreferredCustomer myPref = new PreferredCustomer
                ("Paul Sak", "69 Anal place", "4206942069", 14, false, 1069m);
            Console.WriteLine("Discount Rate : " + myPref.Discount);
        }
    }
}
