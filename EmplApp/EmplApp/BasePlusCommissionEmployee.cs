using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplApp
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;

        public BasePlusCommissionEmployee(string first, string last,
            string ssn, decimal sale, decimal rate, decimal salary) 
            :base(first,last,ssn,sale,rate)
        {
            Salary = salary;
        }
        public decimal Salary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("invalid" +
                        " salary");
                }
                else
                {
                    baseSalary = value;
                }
            }
        }

        public override decimal Earnings()
        {
             return base.Earnings();
        }

        public override string ToString()
        {
            return base.ToString() + "Base Salary: " +
                Salary.ToString("c");
        }
    }

    }

