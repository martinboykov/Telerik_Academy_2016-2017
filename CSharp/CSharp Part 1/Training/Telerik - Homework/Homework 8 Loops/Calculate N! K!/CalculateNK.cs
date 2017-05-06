//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements(also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k<n< 100). Try to use only two loops.
//Examples:

//n     k   n! / (k! * (n-k)!)
//3	    2	3
//4	    2	6
//10	6	210
//52	5	2598960

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CalculateNK
{
    static void Main()
    {
        int n, k, m;

        Console.Write("Enter the first number n:");
        bool isNInt = int.TryParse(Console.ReadLine(), out n);
        Console.Write("Enter the second number k:");
        bool isKInt = int.TryParse(Console.ReadLine(), out k);
        m = n - k;
        double result1 = 1;
        double result2 = m;
        double totalResult = 1;
        if (1 < k & k < n)
        {
            for (int i = k + 1; i < n + 1; i++)
            {
                result1 = result1 * i;
            }
            Console.WriteLine("result1={0}", result1);
            for (int i = 1; i < m; i++)
            {
                result2 = result2 * i;
            }
            result2 = 1 / result2;
            Console.WriteLine("result2={0}", result2);
            totalResult = result1 * result2;
            Console.WriteLine("totalResult={0}", totalResult);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}