using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Person_Class
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 128)
                {
                    age = value;
                }
            }
        }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.Age = age;
            this.IsWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            string info = "";
            info += $"{personId}: ";
            info += $"{firstName} {lastName}";
            info += $"'s favorite color is {favoriteColor}";
            return info;
        }

        public override string ToString()
        {
            string info = "";
            info += $"PersonId: {personId}\n";
            info += $"FirstName: {firstName}\n";
            info += $"LastName: {lastName}\n";
            info += $"Favorite Color: {favoriteColor}\n";
            info += $"Age: {age}\n";
            info += $"Working: {isWorking}\n";
            return info;
        }

        public string ChangeFavoriteColour()
        {
            string newColour = "White";
            favoriteColor = newColour;
            return favoriteColor;
        }

        public int GetAgeInTenYears()
        {
            int newAge = age + 10;
            return newAge;
        }
    }
}