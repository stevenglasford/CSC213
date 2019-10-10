using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Customer : Person
    {
        int CustNum { get; set; }
        bool MailList { get; set; }

        public Customer(string name, string addr, string
            tele, int custN, bool mail) : base(name,addr,tele)
        {
            CustNum = custN;
            MailList = mail;
        }
    }
}
