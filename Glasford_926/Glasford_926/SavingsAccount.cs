using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasford_926
{
    public class SavingsAccount : Account
    {
        private decimal rate;

        public SavingsAccount(decimal initialBalance, decimal rate) 
            : base(initialBalance)
        {
            Rate = rate;
        }

        public decimal Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }

        public decimal CalculateInterest()
        {
            return ((rate/100) * Balance);
        }

    }
}
