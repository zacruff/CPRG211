using Lab_1_Person_Class;
using Lab_1_Relation_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A.)
            Person personOne = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person personTwo = new Person(2, "Gina", "James", "Green", 18, false);
            Person personThree = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person personFour = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            // B.) 
            Console.WriteLine($"{personTwo.DisplayPersonInfo()}\n");

            // C.)
            Console.WriteLine(personThree.ToString());

            // D.)
            personOne.ChangeFavoriteColour();
            Console.WriteLine(personOne.DisplayPersonInfo());

            // E.)
            Console.WriteLine($"\n{personFour.FirstName} {personFour.LastName}'s age in 10 years: {personFour.GetAgeInTenYears()}\n");

            // F.)
            Relation relationOne = new Relation("Sisterhood", personTwo, personFour);
            Relation relationTwo = new Relation("Brotherhood", personOne, personThree);
            Console.WriteLine(relationOne.ShowRelationship());
            Console.WriteLine($"{relationTwo.ShowRelationship()}\n");

            // G.)

            List<Person> personList = new List<Person>();
            personList.Add(personOne);
            personList.Add(personTwo);
            personList.Add(personThree);
            personList.Add(personFour);

            // Calculate average age
            double totalAge = 0;
            foreach (Person person in personList)
            {
                totalAge += person.Age;
            }
            double avgAge = totalAge / (double) personList.Count;
            Console.WriteLine($"Average age is: {avgAge}");

            // Calculate youngest and oldest person
            int youngestAge = 128;
            string youngestPerson = personOne.FirstName;
            foreach (Person person in personList)
            {
                if (person.Age < youngestAge)
                {
                    youngestAge = person.Age;
                    youngestPerson = person.FirstName;
                }
            }
            Console.WriteLine($"The youngest age is {youngestPerson} at {youngestAge} years old.");

            int oldestAge = 0;
            string oldestPerson = personOne.FirstName;
            foreach (Person person in personList)
            {
                if (person.Age > oldestAge)
                { 
                oldestAge = person.Age;
                oldestPerson = person.FirstName;
                }
            }
            Console.WriteLine($"The oldest person is {oldestPerson} at {oldestAge} years old.");

            // Names of people that start with M
            Console.WriteLine("People with names starting in 'M':");
            foreach (Person person in personList)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    Console.WriteLine(person.FirstName);
                }
            }

            // Person information of the person who likes the colour blue
            Console.WriteLine("The information of the person who likes the colour blue:");
            foreach (Person person in personList)
            {
                if (person.FavoriteColor == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }    
        }
    }
}
