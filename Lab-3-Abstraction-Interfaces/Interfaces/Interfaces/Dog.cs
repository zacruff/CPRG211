﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Dog : IAnimal
    {
        // Properties
        public string Name { get; }
        public string Color { get; }
        public double Height { get; }
        public int Age { get; }

        // Constructor
        public Dog(string name, string color, double height, int age)
        {
            Name = name;
            Color = color;
            Height = height;
            Age = age;
        }

        // Methods
        public string Cry()
        {
            return "Woof!";
        }
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
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
