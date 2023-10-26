namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create dog object
            Console.Write("Enter the name of a dog: ");
            string dogName = Console.ReadLine();
            Console.Write($"Give {dogName} a height (in inches): ");
            double dogHeight = double.Parse(Console.ReadLine());
            Console.Write($"Give {dogName} an age: ");
            int dogAge = int.Parse(Console.ReadLine());
            Console.Write($"Give {dogName} a color: ");
            string dogColor = Console.ReadLine();
            Dog dog1 = new Dog(dogName, dogColor, dogHeight, dogAge);
            Console.WriteLine(dog1.ToString());
            dog1.Eat();
            Console.WriteLine(dog1.Cry());

            // Create cat object
            Console.Write("Enter the name of a cat: ");
            string catName = Console.ReadLine();
            Console.Write($"Give {catName} a height (in inches): ");
            double catHeight = double.Parse(Console.ReadLine());
            Console.Write($"Give {catName} an age: ");
            int catAge = int.Parse(Console.ReadLine());
            Console.Write($"Give {catName} a color: ");
            string catColor = Console.ReadLine();
            Cat cat1 = new Cat(catName, catColor, catHeight, catAge);
            Console.WriteLine(cat1.ToString());
            cat1.Eat();
            Console.WriteLine(cat1.Cry());

            // Creating animal objects
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog1);
            animals.Add(cat1);
            Dog dog2 = new Dog("Cujo", "Brown", 63.4, 1);
            Dog dog3 = new Dog("Peanut", "White", 53.4, 3);
            Cat cat2 = new Cat("Garfield", "Orange", 70.2, 15);
            Cat cat3 = new Cat("Cleopatra", "Brown", 43.1, 20);
            animals.Add(dog2);
            animals.Add(dog3);
            animals.Add(cat2);
            animals.Add(cat3);
            foreach (IAnimal animal in animals)
                Console.WriteLine(animal.Name);
        }
    }
}