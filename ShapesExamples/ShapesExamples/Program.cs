using System.Security.Principal;

namespace ShapesExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double width1 = 10;
            double height1 = 8;
            string color1 = "Blue";

            Rectangle rect1;
            rect1 = new Rectangle(width1, height1, color1);

            Console.WriteLine("Created rect1.");
            Console.WriteLine(rect1.ToString());
            Console.WriteLine($"Perimeter of rect1: {rect1.CalcPerimeter()}");

            Rectangle rect2;    
            rect2 = new Rectangle(2, 8, "Green");

            Console.WriteLine("Created rect2.");
            Console.WriteLine(rect2.ToString());
            Console.WriteLine($"Perimeter of rect2: {rect2.CalcPerimeter()}");

            Square square1 = new Square(15, "Red");

            double squareArea1 = square1.CalcArea();
            Console.WriteLine(squareArea1);

        }
    }
}