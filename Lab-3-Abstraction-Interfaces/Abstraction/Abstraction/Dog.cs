using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Dog : Animal
    {
        public Dog(int age, string name, string color) : base(age, name, color) { }

        public override string ToString()
        {
            string dogInfo = "";
            dogInfo += $"Name: {Name}\n";
            dogInfo += $"Age: {Age}\n";
            dogInfo += $"Color: {Color}";
            return dogInfo;
        }
        public override string Eat()
        {
            string eat = "Dogs eat meat.";
            return eat;
        }
    }
}
