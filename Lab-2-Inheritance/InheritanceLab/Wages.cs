using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    internal class Wages : Employee
    {
        // Fields
        private double rate;
        private double hours;
        // Properties
        public double Rate
        {
            get => rate;
            set
            {
                if (rate >= 0)
                {
                    rate = value;
                }
            }
        }
        public double Hours
        {
            get => hours;
            set
            {
                if (hours >= 0)
                {
                    hours = value;
                }
            }
        }

        // Constructors
        public Wages() { }
        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            Rate = rate;
            Hours = hours;
        }

        // Methods
        public double GetPay(double rate, double hours)
        {
            double pay = 0;
            if (hours > 40)
            {
                double overtimeHours = hours - 40;
                hours -= overtimeHours;
                pay += (rate * hours) + ((rate * 1.5) * overtimeHours);
                return pay;
            } else
            {
                pay += rate * hours;
                return pay;
            }

        }
    }
}
