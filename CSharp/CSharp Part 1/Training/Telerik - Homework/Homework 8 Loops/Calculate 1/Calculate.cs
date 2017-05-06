//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k(1 < k < n < 100).
//Use only one loop.
//Examples:

//n    k    n! / k!
//5	   2	60
//6	   5	6
//8	   3	6720

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CalculateNandK
{
    static void Main()
    {
        int N, K;
        double result = 1;
        Console.Write("Enter the first number N:");
        bool isNInt = int.TryParse(Console.ReadLine(), out N);
        Console.Write("Enter the second number K:");
        bool isKInt = int.TryParse(Console.ReadLine(), out K);
        if (isNInt && isKInt && (K > 1) && (K < N) && ((N < 100)))
        {
            for (int i = K + 1; i < N + 1; i++)
            {
                result = result * i;
            }


            Console.WriteLine("result={0}", result);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}