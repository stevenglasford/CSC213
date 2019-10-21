using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class PreferredCustomer : Customer
    {
        decimal Amount { get; set; }

        public PreferredCustomer(string name, string addr, string
            tele, int custN, bool mail, decimal spent)
            : base(name, addr, tele, custN, mail)
        {
            Amount = spent;
        }
        
        public decimal Discount
        {
            get
            {
                if (Amount >= 2000)
                {
                    return 0.1m;
                }
                else if (Amount >= 1500m)
                {
                    return 0.7m;
                }
                else if (Amount >= 1000m)
                {
                    return 0.6m;
                }
                else if (Amount >= 500m)
                {
                    return 0.5m;
                }
                else
                {
                    return 0m;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + ";\tAmount Spent: " + Amount + ";\tDiscount: " + Discount;
        }
    }
}
