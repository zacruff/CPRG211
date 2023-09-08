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
for (double i = low; i <= high; i++)
{
    string numString = i.ToString();
    numlist.Add(numString);
}

numlist.Reverse();

File.WriteAllLines("C:/cprg211/numbers.txt", numlist.ToArray());
string[] numArray = File.ReadAllLines("C:/cprg211/numbers.txt");
double total = 0;
foreach (string num in numArray)
{
    double numInt = Convert.ToInt32(num);
    total += numInt;
}
Console.WriteLine("The sum of the numbers in numbers.txt is " + total);


