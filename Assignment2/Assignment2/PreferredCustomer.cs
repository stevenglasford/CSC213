using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PreferredCustomer : Customer
    {
        decimal Discount { get; set; }
        decimal Amount { get; set; }

        public PreferredCustomer(string name, string addr, string
            tele, int custN, bool mail,decimal dis, decimal spent)
            : base(name, addr, tele, custN, mail)
        {
            Discount = dis;
            Amount = spent;
        }

    }
}
