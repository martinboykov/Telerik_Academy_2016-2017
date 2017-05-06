using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString((Convert.ToInt64(Console.ReadLine())), 2).TrimStart('0'));
        }
    }
}
