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
            int suma=0;
            foreach (Person familiar in children )
            {
                suma =+ familiar.Age;
            }
        }

        public override void Old(Person person)
        {
            /*
            foreach (Node familiar in children )
            {
                int age=familiar.Person.Age;
                int max = age.Max();
            }
            */
            for (int i = 0; i < length; i++)
            {
                
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
