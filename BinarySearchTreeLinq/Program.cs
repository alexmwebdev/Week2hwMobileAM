using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTreeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            Random rnd = new Random();
            int arrayLen = 5;
            int[] data;
            data = new int[arrayLen];// allocate space for array
            for (int i = 0; i < arrayLen; i++)
            {
                int x = rnd.Next(0, 100);
                data[i] = x;
                Node n = new Node(x);
                if (root == null)
                {
                    Console.WriteLine("Setting " + n.label + " to the root");
                    root = n;
                }
                else
                {
                    n.AddNode(root);
                }
            }

            Array.Sort(data);
            IEnumerable<int> numQuery1 =
            from num in data
            orderby num
            select num;
            Console.WriteLine("Sorted Random Numbers are:");
            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int searchInt; // number to be searched in a binary search
            int position; // location of searched number in array

            // create array for binary search
            BinaryArray searchArray = new BinaryArray(data);

            // get user's number input
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // asks the user to repeatedly enter a number that is not -1 (-1 ends the program)
            while (searchInt != -1)
            {
                // use binary search to try to find user's integer
                position = searchArray.BinarySearch(searchInt);

                // return value of -1 indicates integer was not found
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

                // Prompt the user for new number to be searched
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }
        
    }
}
