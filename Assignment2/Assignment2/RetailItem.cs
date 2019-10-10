using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class RetailItem
    {
        string Description { get; set; }
        int UnitsOnHand { get; set; }
        decimal Price { get; set; }

        public RetailItem(string descrip, int units, decimal price)
        {
            Description = descrip;
            UnitsOnHand = units;
            Price = price;
        }

    }
}
