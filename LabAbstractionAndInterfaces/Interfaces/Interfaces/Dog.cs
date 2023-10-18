using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal abstract class Dog : IAnimal
    {
        public Dog(string name, string color, double height, int age) { }
    }
}
