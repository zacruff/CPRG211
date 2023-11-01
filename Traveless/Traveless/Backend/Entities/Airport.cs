using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Backend.Entities
{
    public class Airport
    {
        // Properties
        public string Code { get; set; }
        public string Name { get; set; }

        // Constructor
        public Airport(string code, string name)
        {
            Code = code;
            Name = name;
        }

        // Method
        public override string ToString()
        {
            return $"{Code},{Name}";
        }
    }
}
