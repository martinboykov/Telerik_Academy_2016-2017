//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula

//Write a program to calculate the Nth Catalan number by given N

//Input
//On the only line, you will receive the number N

//Output
//Output a single number - the Nth Catalan number

//Constraints
//N will always be a valid integer number in the range[0, 100]
//Hint: overflow is possible.
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input   Output

//n       Catalan(n)
//0	      1
//5	      42
//10	  16796
//15	  9694845

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class CatalanNumbers
{
    static void Main()
    {
        int N, k, m;
        bool isNInt = int.TryParse(Console.ReadLine(), out N);
        k = N + 1;
        m = N * 2;
        BigInteger result1 = 1;
        BigInteger result2 = 1;
        BigInteger result3 = 1;
        BigInteger totalResult = 1;
        if (0 <= N & N <= 100)
        {
            for (int i = 1; i < N + 1; i++)
            {
                result1 = result1 * i;
            }
            for (int i = 1; i < k + 1; i++)
            {
                result2 = result2 * i;
            }
            for (int i = 1; i < m + 1; i++)
            {
                result3 = result3 * i;
            }
            totalResult = result3 / (result2 * result1);
            Console.WriteLine("{0}", totalResult);
        }
    }
}