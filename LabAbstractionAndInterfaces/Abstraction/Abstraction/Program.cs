namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Animal Abstraction Lab.");
            // Dog
            Console.Write("Please enter a name for a dog: ");
            string dogName = Console.ReadLine();
            Console.Write($"What color is {dogName}? ");
            string dogColor = Console.ReadLine();
            Console.Write($"How old is {dogName}? ");
            int dogAge = int.Parse(Console.ReadLine());
            Dog dog = new Dog(dogAge, dogName, dogColor);
            Console.WriteLine(dog.ToString());
            Console.WriteLine(dog.Eat());
            // Cat
            Console.Write("Please enter a name for a cat: ");
            string catName = Console.ReadLine();
            Console.Write($"What color is {catName}? ");
            string catColor = Console.ReadLine();
            Console.Write($"How old is {catName}? ");
            int catAge = int.Parse(Console.ReadLine());
            Cat cat = new Cat(catAge, catName, catColor);
            Console.WriteLine(cat.ToString());
            Console.WriteLine(cat.Eat());
        }
    }
}