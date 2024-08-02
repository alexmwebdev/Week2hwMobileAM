using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeLinq
{
    public class BinaryArray
    {
        public int[] data; // array of values
        public static Random generator = new Random(); // generates randome numbers for binary search

        // Binary Search constructor
        public BinaryArray(int[] arrayData)
        {
            data = arrayData;
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
