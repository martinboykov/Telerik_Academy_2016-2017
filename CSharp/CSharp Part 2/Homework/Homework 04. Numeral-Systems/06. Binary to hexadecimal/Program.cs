using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt64((Console.ReadLine()), 2).ToString("X"));

        }
    }
}
