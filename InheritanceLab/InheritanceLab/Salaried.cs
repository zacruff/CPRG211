using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    internal class Salaried : Employee
    {
        // Field
        private double salary;
        // Property
        public double Salary
        {
            get => salary;
            set
            {
                if (salary >= 0)
                {
                    salary = value; 
                }
            }
        }
        public Salaried(string id, string name, string address, string phone, long sin) : base(id, name, address, phone)
        {

        }
    }
}
