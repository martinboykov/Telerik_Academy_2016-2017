//Calculate Again

//Description
//Write a program that calculates N! / K! for given N and K.

//Use only one loop.

//Input
//On the first line, there will be only one number - N
//On the second line, there will be only one number - K

//Output
//Output a single line, consisting of the result from the calculation described above.

//Constraints
//1 < K<N< 100
//Hint: overflow is possible
//N and K will always be valid integer numbers
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input   Output
//5
//2	      60
//6
//5	      6
//8       
//3	      6720

using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace _06.Calculate_Again_
{
    class CalculateAgain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger result1 = 1;
            for (int i = K+1; i < N + 1; i++)
            {
                result1 = result1 * i;
            }
            Console.WriteLine("{0}", result1);
        }
    }
}
