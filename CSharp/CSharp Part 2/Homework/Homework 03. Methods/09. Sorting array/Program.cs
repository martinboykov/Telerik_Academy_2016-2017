using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            List<BigInteger> numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                else
                {
                    Console.Write("{0}", numbers[i]);
                }
            }
        }
    }
}
