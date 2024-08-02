using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            Console.WriteLine();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            Console.WriteLine();
            myStack.PrintStack();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }
        public class Stack
        {
            static readonly int MAX = 4;
            int top;
            int[] stack = new int[MAX];

            public bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }
            public bool Push(int data)
            {
                // Adds new item on top of previous item in the stack
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }

            public int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }

            public void Peek()
            {
                // returns the top item in the stack
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }

            public void PrintStack()
            {
                // prints all items in the stack
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }
    }
}
