//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a whitespace.

//Input
//The input will consist of a single line - the number N

//Output
//The output should consist of a single line - the numbers from 1 to N, separated by a whitespace

//Constraints
//N will be a valid positive 32-bit integers
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//n    output
//3	   1 2 3
//5	   1 2 3 4 5

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class NumberFrom1toN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}