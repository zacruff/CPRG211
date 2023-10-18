using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Circle
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value <= 0 || double.IsInfinity(value))
                    throw new InvalidRadiusException(value);
                else
                    _radius = value;
            }
        }

        public Circle(double radius) 
        {
            Radius = radius;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Area: {this.Area()}";
        }
    }
}
