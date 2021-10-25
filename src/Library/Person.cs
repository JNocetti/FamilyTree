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
    }
}