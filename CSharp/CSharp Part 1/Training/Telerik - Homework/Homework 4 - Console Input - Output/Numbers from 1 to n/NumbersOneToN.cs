//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval[1..n], each on a single line.
//Note: You may need to use a for-loop.

//Examples:

//input   output
//3	      1
//        2         
//        3         
//5	      1
//        2         
//        3         
//        4         
//        5         
//1	      1

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

class NumbersOneToN
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers are: ");
        for (int i = 1; i <= n; i++)
        {

            Console.WriteLine(i);
        }
    }
}