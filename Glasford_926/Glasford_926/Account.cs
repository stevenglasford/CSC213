using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasford_926
{
    class Account
    {
        private decimal balance = 0;

        public Account(decimal initialBalance)
        {
            Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0.0m)
                {
                    balance = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Stupid cunt, you" +
                        " entered an invalid amount of money!");
                }
            }
        }

    }
}
