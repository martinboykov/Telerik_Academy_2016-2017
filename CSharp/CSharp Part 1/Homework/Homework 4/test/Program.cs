using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 0;
            long b = 1;
            long temp = 0;

            uint N = uint.Parse(Console.ReadLine());

            long[] fibArr = new long[N];

            if (N >= 1 && N <= 50)
            {
                for (int i = 1; i < N; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;

                    fibArr[i] = a;
                }
            }
            Console.WriteLine(string.Join(", ", fibArr));
        }
    }
}