//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n      comments
//1	     0
//3	     0 1 1
//10	 0 1 1 2 3 5 8 13 21 34

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class FibonacciNumbers
{
    static void Main()
    {
        {

            int i, count, f1 = 0, f2 = 1, f3 = 0;

            Console.Write("Enter the length of the Fibonacci sequence: ");

            count = int.Parse(Console.ReadLine());
            if (count <= 1)
            {
                Console.Write("Fibonacci sequence is: {0}", f1);
            }
            else
            {
                Console.Write("Fibonacci sequence is: {0}", f1);
                Console.Write(" {0}", f2);
                for (i = 2; i < count; i++)
                {
                    f3 = f1 + f2;
                    Console.Write(" {0}", f3);
                    f1 = f2;
                    f2 = f3;
                }
            }
            Console.WriteLine();
        }
    }
}