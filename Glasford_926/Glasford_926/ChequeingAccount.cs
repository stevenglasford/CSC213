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

        public override void Credit(decimal dollas)
        {
            if (Balance - fee - dollas >= 0.0m)
            {
                base.Credit(dollas + fee);
            }
            else
            {
                throw new ArgumentOutOfRangeException("You too poor " +
                    "to afford a fee of: $" + fee);
            }
        }

        public override void Debit(decimal green)
        {
            if (Balance >= (green + fee) )
            {
                base.Debit(green + fee);
            }
            else
            {
                throw new ArgumentOutOfRangeException("You too poor " +
                    "to afford a fee of: $" + fee);
            }
        }


    }
}
