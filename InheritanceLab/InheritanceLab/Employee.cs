using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    internal class Employee
    {
        // Fields
        private string id;
        private string name;
        private string address;
        private string phone;
        // Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }

        // Constructor
        public Employee(string id, string name, string address, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
        }

        public override string ToString()
        {
            string info = "";
            info += $"ID: {id}\n";
            info += $"Name: {name}\n";
            info += $"Address: {address}\n";
            info += $"Phone: {phone}\n";
            return info;
        }
    }
}
