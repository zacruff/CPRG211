using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() { }

        public InvalidRadiusException(double radius)
        {
            if (radius == 0 || double.IsInfinity(radius))
                Console.WriteLine("Radius cannot be zero or infinity.");
            if (radius < 0 || double.IsInfinity(radius))
                Console.WriteLine("Radius cannot be negative or infinity.");
        }
    }
}
