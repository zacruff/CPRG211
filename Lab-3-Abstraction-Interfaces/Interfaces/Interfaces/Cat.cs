using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Cat : IAnimal
    {
        // Properties
        public string Name { get; }
        public string Color { get; }
        public double Height { get; }
        public int Age { get; }

        // Constructor
        public Cat(string name, string color, double height, int age)
        {
            Name = name;
            Color = color;
            Height = height;
            Age = age;
        }

        // Methods
        public string Cry()
        {
            return "Meow!";
        }
        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public override string ToString()
        {
            string info = "";
            info += $"Name: {Name}\n";
            info += $"Color: {Color}\n";
            info += $"Height: {Height}\n";
            info += $"Age: {Age}";
            return info;
        }
    }
}
