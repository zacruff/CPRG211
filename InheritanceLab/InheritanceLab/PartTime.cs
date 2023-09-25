using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    internal class PartTime : Employee
    {
        // Field
        private double rate;
        // Property
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
        public PartTime(string id, string name, string address, string phone, long sin) : base(id, name, address, phone)
        {

        }
    }
}
