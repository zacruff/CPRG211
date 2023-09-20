using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExamples
{
    internal class Square : Rectangle
    {

        // Inherited Class needs a user-defined class because parent Class has one
        // base() refers to original constructor in parent class
        public Square(double side, string color) : base(side, side, color)
        {
        }
    }
}
