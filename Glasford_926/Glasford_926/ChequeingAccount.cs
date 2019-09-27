using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasford_926
{
    public class ChequeingAccount : Account
    {
        private decimal fee = 0;

        public ChequeingAccount(decimal initialBalance, decimal fee) 
            : base(initialBalance)
        {
            this.fee = fee;
        }

        public decimal Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }

        public override void Credit(decimal dollas)
        {
            if(dollas < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong credit");
            }
            else if (Balance - fee - dollas >= 0.0m)
            {
                base.Credit(dollas - fee);
            }
            else
            {
                throw new ArgumentOutOfRangeException("You too poor " +
                    "to afford a fee of: $" + fee);
            }
        }

        public override void Debit(decimal green)
        {
            if (green < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong Debit bitch");
            }
            else if (Balance >= (green + fee) )
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
