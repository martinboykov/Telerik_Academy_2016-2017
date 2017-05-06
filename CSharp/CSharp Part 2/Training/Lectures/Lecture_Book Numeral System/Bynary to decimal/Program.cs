using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bynary_to_decimal
{
    class Program
    {
        static int BinaryToDecimal(string binary)
        {
            int sum = 0;
            foreach (var bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }
            return sum;
        }
        static void Main()
        {
            Console.WriteLine(BinaryToDecimal("110"));
        }
    }
}
