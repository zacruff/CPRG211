using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Animal
    {
        private int age;
        public string? Name { get; set; }
        public string? Color { get; set; }
        public int Age
        { get => age;
            set 
            { if (value > 0) age = value; else Console.WriteLine("Invalid age."); } 
        }
        
        public Animal(int age, string? name, string? color)
        {
            Age = age;
            Name = name;
            Color = color;
        }

        public abstract string ToString();
        public abstract string Eat();
    }
}
