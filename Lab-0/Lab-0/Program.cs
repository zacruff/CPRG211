namespace Lab0
{
    /// <summary>
    /// Lab 0 for CPRG211
    /// Author: Zac Ruff (zac.ruff@edu.sait.ca)
    /// Date: September 15, 2023
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            static double LowInput()
            {
                Console.Write("Enter a low number: ");
                double low = Convert.ToDouble(Console.ReadLine());
                return low;
            }

            static double HighInput()
            {
                Console.Write("Enter a high number: ");
                double high = Convert.ToDouble(Console.ReadLine());
                return high;
            }

            double low = LowInput();
            while (low < 0)
            {
                Console.WriteLine("Please enter a positive number.");
                low = LowInput();
            }

            double high = HighInput();
            while (high < low)
            {
                Console.WriteLine($"Enter a number higher than {low}");
                high = HighInput();
            }

            double difference = high - low;
            Console.WriteLine($"The difference between the two numbers is {difference}");

            List<string> numlist = new List<string>();
            for (double num = low; num <= high; num++)
            {
                string numString = num.ToString();
                numlist.Add(numString);
            }

            foreach (string numString in numlist)
            {
                double num = Convert.ToDouble(numString);
                if (IsPrime(num))
                {
                    Console.WriteLine($"{num} is prime.");
                }
            }
            static bool IsPrime(double n)
            {
                for (double denominator = n - 1; denominator > 1; denominator--)
                {
                    double remainder = n % denominator;
                    if (remainder == 0)
                        return false;
                }
                return true;
            }

            numlist.Reverse();
            File.WriteAllLines("numbers.txt", numlist.ToArray());
            Console.WriteLine("Wrote data to: numbers.txt");
            string[] numArray = File.ReadAllLines("numbers.txt");
            double total = 0;
            foreach (string num in numArray)
            {
                double numInt = Convert.ToDouble(num);
                total += numInt;
            }
            Console.WriteLine("The sum of the numbers in numbers.txt is " + total);
        }
    }
}

