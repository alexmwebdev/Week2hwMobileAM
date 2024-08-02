using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<String> nameList = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            nameList.AddLast("Alex");
            nameList.AddLast("Amber");
            nameList.AddLast("Erica");
            nameList.AddLast("Tom");
            nameList.AddLast("Anne");
            nameList.AddLast("Ven");

            Console.WriteLine("List of names in a Linked List:");
            Console.WriteLine();
            // Accessing the elements of 
            // LinkedList Using foreach loop
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
