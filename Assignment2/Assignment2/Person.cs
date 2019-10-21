using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Person
    {
        string Name { get; set; }
        string Address { get; set; }
        string Telephone { get; set; }

        //constructor
        public Person(string name, string addr, string tele)
        {
            Name = name;
            Address = addr;
            Telephone = tele;
        }

        public override string ToString()
        {
            return base.ToString() + "\nName: " + Name + ";\tAddress: " 
                + Address + ";\tTelephone: " + Telephone;
        }
    }
}
