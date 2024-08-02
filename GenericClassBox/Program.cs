using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a new Box called intBox
            Box<int> intBox = new Box<int>();
            // Add Contents to the intBox
            intBox.Add(23);
            // Display contents of intBox
            Console.WriteLine($"Content of the integer box: {intBox.GetContent()}");


            // Declare a new Box called stringBox
            Box<string> stringBox = new Box<string>();
            // Add Contents to the stringBox
            stringBox.Add("This is Alex.");
            // Display contents of stringBox
            Console.WriteLine($"Content of the string box: {stringBox.GetContent()}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
    public class Box<T>
    {
        private T content;

        public void Add(T item)
        {
            content = item;
        }

        public T GetContent()
        {
            return content;
        }
        public T DeleteContent()
        {
            return content = default(T);
        }
    }
}
