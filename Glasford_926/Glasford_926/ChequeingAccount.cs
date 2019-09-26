using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasford_926
{
    class ChequeingAccount : Account
    {
        private decimal fee = 0;

        public ChequeingAccount(decimal initialBalance, decimal fee) 
            : base(initialBalance)
        {
            this.Fee = fee;
        }

        decimal Fee
        {
            get
            {
                return fee;
            }
            set
            {
                Fee = fee;
            }
        }
    }
}
