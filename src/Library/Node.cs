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

        public override void Visit (Person person)
        {
            int total=0;
            foreach ( Person persona in person.family)
            {
                total+=persona.Age;
            }
        }

        public override void Old(Person person)
        {
            int max=0;
            foreach (Person familiar in children )
            {
                int age=familiar.Age;
                if (age>max)
                {
                    max=age;
                }
            }
            

        }
        public override void LargestName(Person person)
        {
            

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
