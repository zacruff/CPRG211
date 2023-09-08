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

// Task 1: Creating Variables

Console.WriteLine("Task 1: Creating Variables");
double low = LowInput();
double high = HighInput();
double difference = high - low;
Console.WriteLine("The difference between the two numbers is " + difference);

// Task 2: Looping and Input Validation

Console.WriteLine("\nTask 2: Looping and Input Validation");
Console.WriteLine("Part 1");
double lowPositive = LowInput();
while (lowPositive < 0)
{
    Console.WriteLine("Please enter a positive number.");
    lowPositive = LowInput();
}
Console.WriteLine("Part 2");
double lowNumber = LowInput();
double highNumber = HighInput();
while (highNumber < lowNumber)
{
    Console.WriteLine("Enter a number higher than " + lowNumber);
    highNumber = HighInput();
}

// Task 3: Using Arrays and File I/O

Console.WriteLine("\nTask 3: Using Arrays and File I/O");
double numLow = LowInput();
double numHigh = HighInput();
List<string> numlist = new List<string>();
for (double i = numLow; i <= numHigh; i++)
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


