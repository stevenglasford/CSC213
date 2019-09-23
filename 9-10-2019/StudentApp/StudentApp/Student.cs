using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Student
    {
        private double gpa;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value >= 0 && value <= 4.0)
                {
                    gpa = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1},  GPA={2}",
                FirstName, LastName, GPA);
        }
    }
}
