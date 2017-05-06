//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).
//The input starts by the number n(alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

//Example 1:
//input   output
//3       min = 1 
//2       max = 5 
//5       sum = 8 
//1	      avg = 2.67

//Example 2:
//input   output
//  2     min = -1
//- 1     max = 4
//  4	  sum = 3
//        avg = 1.50

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            string terminate;
            try
            {
                Console.WriteLine("How many integer numbers (n=?) are you going to enter?");
                Console.Write("n = ");
                int n = int.Parse(Console.ReadLine());
                int[] numbers = new int[n];
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Number {0} is: ", i + 1);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("The numbers are: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                Console.WriteLine();
                Console.Write("min = ");
                Console.WriteLine(numbers.Min());
                Console.Write("max = ");
                Console.WriteLine(numbers.Max());
                Console.Write("sum = ");
                Console.WriteLine(numbers.Sum());
                Console.Write("avg = ");
                Console.WriteLine("{0:F2}", numbers.Average());



                Console.WriteLine();
                Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Wrong input!\nPress 'enter' to try aggain or type 'exit' in the console to exit from the program!");

                terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}

//Not exactly what is suppose to look like, but this way is more user friendly.