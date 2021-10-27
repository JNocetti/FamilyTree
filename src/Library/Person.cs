using System.Collections.Generic;
namespace Library
{
    public class Person
    {
        public string Name;
        public int Age {get; private set;}

        

        

        public Person (string name, int age)
        {
            this.Name=name;
            this.Age=age;
        }
        public List<Person> family = new List<Person>();
        
    }
}