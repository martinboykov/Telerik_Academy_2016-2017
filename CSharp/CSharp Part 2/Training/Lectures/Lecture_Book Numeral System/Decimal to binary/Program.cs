using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bynary_to_decimal
{
    class Program
    {
        static string DecimalToBinary(int decValue)
        //static string HexaDecimalToBinary(int decValue)
        {
            string binary = "";
            while (decValue != 0)
            {
                //int bit = decValue % 2;
                //binary = bit + binary;
                //decValue /= 2;
                //or
                int bit = decValue & 1;
                binary = bit + binary;
                decValue >>= 1;
            }
            return binary;
        }
        static void Main()
        {
            Console.WriteLine(DecimalToBinary(23));
            // Console.WriteLine(HexaDecimalToBinary(0x17));//workds for Hexadecimal too 
            
        }
    }
}
