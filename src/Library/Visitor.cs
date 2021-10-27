namespace Library
{
    public abstract class Visitor
    {
        public abstract int Visit(Person person);
        public abstract int Old(Person person);
        
        public abstract void LargestName(Person person);
    }
}