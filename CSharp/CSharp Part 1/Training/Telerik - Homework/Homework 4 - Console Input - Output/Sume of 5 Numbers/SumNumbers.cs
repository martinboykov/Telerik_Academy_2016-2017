//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers(given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers                  sum
//1   2    3    4   5	   15
//10  10   10   10  10	   50
//1.5 3.14 8.2  -1  0      11.84

using System;
using System.Globalization;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

class SumNumbers
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter five real numbers separated by single whitespace:");

        while (true)
        {
            try
            {
                string[] numbers = Console.ReadLine().Split();

                string one = numbers[0];
                string two = numbers[1];
                string three = numbers[2];
                string four = numbers[3];
                string five = numbers[4];

                double n1 = double.Parse(one);
                double n2 = double.Parse(two);
                double n3 = double.Parse(three);
                double n4 = double.Parse(four);
                double n5 = double.Parse(five);

                Console.WriteLine("The sum of {0} + {1} + {2} + {3} + {4} is {5}", n1, n2, n3, n4, n5, n1 + n2 + n3 + n4 + n5);

                Console.WriteLine("Use 'enter key' to try aggain or type 'exit' in the console to exit from the program!");
                Console.WriteLine();
                string terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(11111);
                }
                Console.WriteLine("\nTry aggain!\nEnter five real numbers separated by single whitespace:");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nTry aggain!\nEnter five real numbers separated by single whitespace:");
            }
        }
    }
}
