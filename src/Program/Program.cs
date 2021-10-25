using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            */
            Person abuelo_madre = new Person ("Juan Carlos", 70);
            Node node1 = new Node (abuelo_madre);
            Person abuela_madre = new Person ("Blanca", 56);
            Node node2 = new Node (abuela_madre);
            Person abuela_padre = new Person ("Maria", 75);
            Node node3 = new Node(abuela_padre);
            Person madre = new Person ("Solana", 47);
            Node node4 = new Node(madre);
            Person padre = new Person ("Gustavo", 53);
            Node node5 = new Node(padre);
            Person tío_madre = new Person ("Weston", 42);
            Node node6 = new Node(tío_madre);
            Person tío_padre = new Person ("Oscar", 56);
            Node node7 = new Node(tío_padre);
            Person tía_padre = new Person ("Marianela", 56);
            Node node8 = new Node(tía_padre);

        }
    }
}
