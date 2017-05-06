using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToHex
{
    class Program
    {
        static string DecimalToHex(int decValue)
        {
            {
                string result = "";
                string hexDigits = "0123456789ABCDEF";
                do
                {
                    int value = decValue % 16;
                    result = hexDigits[value] + result;
                    decValue /= 16;
                    
                } while (decValue != 0);
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DecimalToHex(172));
        }
    }
}
