using Lab_1_Person_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Relation_Class
{
    internal class Relation
    {
        private string relationshipType;
        private Person person1;
        private Person person2;
        public string RelationType { get => relationshipType; set => relationshipType = value; }

        public Relation(string relationshipType, Person person1, Person person2)
        {
            this.relationshipType = relationshipType;
            this.person1 = person1;
            this.person2 = person2;
        }

        public string ShowRelationship()
        {
            string relationship = $"Relationship between {person1.FirstName} and {person2.FirstName}: {relationshipType}";
            return relationship;
        }
    }
}
