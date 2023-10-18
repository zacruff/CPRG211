using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Cat : Animal
    {
        public Cat(int age, string name, string color) : base(age, name, color) { }
        public override string ToString()
        {
            string catInfo = "";
            catInfo += $"Name: {Name}\n";
            catInfo += $"Age: {Age}\n";
            catInfo += $"Color: {Color}";
            return catInfo;
        }
        public override string Eat()
        {
            string eat = "Cats eat mice";
            return eat;
        }
    }
}
