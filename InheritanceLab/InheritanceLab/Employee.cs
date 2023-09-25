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
        private long sin;
        private string dob;
        private string dept;
        // Properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public long Sin { get => sin; set => sin = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Dept { get => dept; set => dept = value; }


        // Constructors
        public Employee() { }
        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Sin = sin;
            Dob = dob;
            Dept = dept;
        }

        // Methods
        public override string ToString()
        {
            string info = "";
            info += $"ID: {id}\n";
            info += $"Name: {name}\n";
            info += $"Address: {address}\n";
            info += $"Phone: {phone}\n";
            info += $"SIN: {sin}\n";
            info += $"D.O.B: {dob}\n";
            info += $"Dept: {dept}\n";
            return info;
        }
    }
}
