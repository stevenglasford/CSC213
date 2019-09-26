using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasford_926
{
    class SavingsAccount : Account
    {
        private decimal rate;

        public SavingsAccount(decimal initialBalance, decimal rate) 
            : base(initialBalance)
        {
            this.Rate = rate;
        }

        decimal Rate
        {
            get
            {
                return rate;
            }
            set
            {
                Rate = rate;
            }
        }

        public decimal CalculateInterest()
        {
            return ((rate/100) * Balance);
        }

    }
}
