using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTreeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int searchInt; // number to be searched in a binary search
            int position; // location of searched number in array

            // create array for binary search
            BinaryArray searchArray = new BinaryArray(15);

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
    class BinaryArray
    {
        private int[] data; // array of values
        private static Random generator = new Random(); // generates randome numbers for binary search

        // Binary Search constructor
        public BinaryArray(int size)
        {
            data = new int[size]; // allocate space for array

            // fill array with random ints
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 100);
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
        }

        // perform a binary search
        public int BinarySearch(int searchElement)
        {
            int low = 0; //  first element
            int high = data.Length - 1; // Find highest element
            int middle = (low + high + 1) / 2; // Find middle element
            int location = -1; // Return value -1 if not found

            do // Search for element
            {
                // Print remaining elements in array
                Console.Write(RemainingElements(low, high));

                // output spaces for alignment
                for (int i = 0; i < middle; i++)
                    Console.Write("   ");

                Console.WriteLine(" ^ "); // Indicate current middle

                // if element is found at middle

                IEnumerable<int> numQuery2 =
                from num in data
                where num == searchElement
                select num;
                if ((searchElement == data[middle]) && (numQuery2 != null))
                    location = middle; // location is current middle

                // // if the user's searched number is lower than the middle number 
                else if (searchElement < data[middle])
                    high = middle - 1; // eliminate lower half
                else // // if the user's searched number is higher than the middle number 
                    low = middle + 1; // eleminate lower half

                middle = (low + high + 1) / 2; // determine the middle number
            } while ((low <= high) && (location == -1));

            return location; // return location of user's number
        }

        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;

            // to fix spaces for alignment
            for (int i = 0; i < low; i++)
                temporary += "    ";

            // display left elements in array
            for (int i = low; i <= high; i++)
                temporary += data[i] + " ";

            temporary += "\n";
            return temporary;
        }

        // Display values in array
        public override string ToString()
        {
            return RemainingElements(0, data.Length - 1);
        }
    }
}
