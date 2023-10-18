namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle1 = new Circle(1);
                Console.WriteLine(circle1.ToString());
            }
            catch (InvalidRadiusException)
            {
                Console.WriteLine("Please try again.");
            }
            try 
            {
                Circle circle2 = new Circle(0);
                Console.WriteLine(circle2.ToString());
            }
            catch (InvalidRadiusException)
            {
                Console.WriteLine("Please try again.");
            }
            try 
            {
                Circle circle3 = new Circle(-1);
                Console.WriteLine(circle3.ToString());
            }
            catch (InvalidRadiusException) 
            {
                Console.WriteLine("Please try again.");
            }
        }
    }
}