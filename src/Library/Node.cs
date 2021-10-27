using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
namespace Library
{
    public class Node : Visitor
    {


        public Person Person;

        private List<Person> children = new List<Person>();

        public ReadOnlyCollection<Person> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public override int Visit (Person person)
        {
            int total=0;
            foreach ( Person persona in person.family)
            {
                total+=persona.Age;
            }
            return total;
        }

        public override int Old(Person person)
        {
            int max=0;
            foreach (Person familiar in person.family )
            {
                int age=familiar.Age;
                if (age>max)
                {
                    max=age;
                }
            }
            return max;

        }
        public override void LargestName(Person person)
        {
            int max=0;
            foreach (Person familiar in person.family )
            {
                string name=familiar.Name;
                int caracteresname=name.Length();
                if (caracteresname>max)
                {
                    max=caracteresname;
                }
            }

        }

        public Node(Person person)
        {
            this.Person = person;
        }

        public void AddChildren(Person n)
        {
            this.children.Add(n);
        }
        
    }
}
