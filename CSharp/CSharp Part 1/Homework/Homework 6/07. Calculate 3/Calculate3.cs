//Calculate 3!

//Description
//In combinatorics, the number of ways to choose N different members out of a group of N different elements(also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

//Try to use only two loops.

//Input
//On the first line, there will be only one number - N
//On the second line, there will also be only one number - K

//Output
//On the only output line, write the result of the calculation for the provided N and K

//Constraints
//1 < K < N< 100
//Hint: overflow is possible
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//n     k   n! / (k! * (n-k)!)
//3	    2	3
//4	    2	6
//10	6	210
//52	5	2598960

using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int m = N - K;
        BigInteger result1 = 1;
        BigInteger result2 = 1;
        BigInteger totalResult = 1;
        for (int i = K + 1; i <= N; i++)
        {
            result1 = result1 * i;
        }
        for (int k = 1; k < (N - K) + 1; k++)
        {
            result2 = result2 * k;
        }
        totalResult = result1 / result2;
        Console.WriteLine("{0}", totalResult);
    }
}