//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n(0 ≤ n ≤ 100).
//Examples:

//n     Catalan(n)
//0	    1
//5	    42
//10	16796
//15	9694845

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CatalanNumbers
{
    static void Main()
    {
        int n, k, m;

        Console.Write("Enter the first number n:");
        bool isNInt = int.TryParse(Console.ReadLine(), out n);
        k = n + 1;
        m = n * 2;
        double result1 = n;
        double result2 = k;
        double result3 = m;
        double totalResult = 1;
        if (0 <= n & n <= 100)
        {
            for (int i = 1; i < n; i++)
            {
                result1 = result1 * i;
            }
            Console.WriteLine("result1={0}", result1);
            for (int i = 1; i < k; i++)
            {
                result2 = result2 * i;
            }
            Console.WriteLine("result2={0}", result2);
            for (int i = 1; i < m; i++)
            {
                result3 = result3 * i;
            }
            Console.WriteLine("result3={0}", result3);
            totalResult = result3/(result2 * result1);
            Console.WriteLine("totalResult={0}", totalResult);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}