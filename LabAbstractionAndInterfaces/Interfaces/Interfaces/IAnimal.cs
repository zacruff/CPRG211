using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IAnimal
    {
        string Name { get; }
        string Color { get; }
        double Height { get; }
        int Age { get; }

        abstract void Eat();
        string Cry();
    }
}
