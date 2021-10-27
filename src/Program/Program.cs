using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person abuelo_madre = new Person ("Juan Carlos", 70);
            Node node_abuelo_madre = new Node (abuelo_madre);
            Person tío_madre = new Person ("Weston", 42);
            Person madre = new Person ("Solana", 47);
            node_abuelo_madre.AddChildren(tío_madre);
            node_abuelo_madre.AddChildren(madre);
            
            Person abuela_madre = new Person ("Blanca", 56);
            Node node_abuela_madre = new Node (abuela_madre);
            node_abuela_madre.AddChildren(tío_madre);
            node_abuela_madre.AddChildren(madre);
            
            Person abuela_padre = new Person ("Maria", 75);
            Node node_abuela_padre = new Node(abuela_padre);
            Person padre = new Person ("Gustavo", 53);
            Person tío_padre = new Person ("Oscar", 56);
            Person tía_padre = new Person ("Marianela", 56);
            node_abuela_padre.AddChildren(padre);
            node_abuela_padre.AddChildren(tío_padre);
            node_abuela_padre.AddChildren(tía_padre);

        }
    }
}
