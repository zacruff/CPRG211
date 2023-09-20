using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExamples
{
    internal class Rectangle
    {
        // Constants

        // Fields

        private double width;
        private double height;
        private string color;

        // Properties

        public double Width
        {
            get { return width; }
            set {
                if (value <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.")
                }

                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set {
                if (value <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }
                    
                height = value; 
            }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Constructor(s)
        public Rectangle(double width, double height, string color)
        {
            this.width = width;
            this.height = height;
            Color = color;
        }
        // Methods
    }
}
