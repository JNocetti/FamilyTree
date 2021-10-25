namespace Library
{
    public abstract class Visitor
    {
        public abstract void Visit(Person person);
        public abstract void Old(Person person);

        public abstract void LargestName(Person person);
    }
}