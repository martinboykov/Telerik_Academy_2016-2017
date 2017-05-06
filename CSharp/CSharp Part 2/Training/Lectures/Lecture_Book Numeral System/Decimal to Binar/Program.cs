using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binar
{
    class Program
    {
        static string DecimalToBinary(int decValue)
        //static string HexaDecimalToBinary(int decValue)
        {
            string binary = "";
            do
            {
                //int bit = decValue % 2;
                //binary = bit + binary;
                //decValue /= 2;
                //or
                int bit = decValue & 1;
                binary = bit + binary;
                decValue >>= 1;
            } while (decValue != 0);
            return binary;
        }
        static void Main(string[] args)
        {
        }
    }
}
