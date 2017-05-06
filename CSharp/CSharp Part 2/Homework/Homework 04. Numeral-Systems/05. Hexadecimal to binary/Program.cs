using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(Convert.ToInt64((Console.ReadLine()), 16), 2));
        }
    }
}
