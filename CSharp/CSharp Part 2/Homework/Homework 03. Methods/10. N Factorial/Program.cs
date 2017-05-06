using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(N)); 
        }
        public static BigInteger CalculateFactorial(int N)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
