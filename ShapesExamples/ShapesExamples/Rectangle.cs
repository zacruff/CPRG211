using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
                    throw new Exception("Width cannot be zero or negative.");
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

            // Pass through property first, not directly to field
            Width = width;
            Height = height;
            Color = color;
        }
        // Methods

        public double CalcPerimeter()
        {
            double perimeter;

            perimeter = (width*2) + (height*2);

            return perimeter;
        }

        public double CalcArea()
        {
            double area;

            area = width * height;

            return area;
        }

        public override string ToString()
        {
            string rectInfo = "";
            rectInfo += $"Width: {width}\n";
            rectInfo += $"Height: {height}\n";
            rectInfo += $"Color: {color}\n";
            return rectInfo;
        }
    }
}
