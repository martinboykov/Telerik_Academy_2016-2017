using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class GCD1
    {
        static void Main()
        {
            string numberString = Console.ReadLine();
            string[] numbersArray = numberString.Split(' ');
            int[] numbers = Array.ConvertAll(numbersArray, int.Parse);
            Console.WriteLine(GCD(numbers));
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static int GCD(int[] integerSet)
        {
            return integerSet.Aggregate(GCD);
        }
    }
}