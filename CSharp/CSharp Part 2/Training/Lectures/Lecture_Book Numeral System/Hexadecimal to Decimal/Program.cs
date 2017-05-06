using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bynary_to_decimal
{
    class Program
    {
        
        static int HexadecimalToDecimal(char hexDigit)
        {
            if (char.IsDigit(hexDigit))
            {
                return hexDigit - '0';
            }
            return char.ToLower(hexDigit) - 'a' + 10;
        }
        

        static Dictionary<char, string> HexToBin = new Dictionary<char, string>()
        {
        {'0', "0000"},
        {'1', "0001"},
        {'2', "0010"},
        {'3', "0011"},
        {'4', "0100"},
        {'5', "0101"},
        {'6', "0110"},
        {'7', "0111"},
        {'8', "1000"},
        {'9', "1001"},
        {'A', "1010"},
        {'b', "1011"},
        {'C', "1100"},
        {'d', "1101"},
        {'E', "1110"},
        {'F', "1111"}
                    };
        //static string HexToBinary(string hex)
        //{
        //    string result = "";
        //    foreach (char hexDigit in hex)
        //    {
        //        result += HexToBin[hexDigit];
        //    }
        //    return result.TrimStart('0');//remove leading zeros
        //}
        static void Main()
        {
           char[] hexDigits = "0123456789AbCdEF".ToCharArray();//must think about "00000" returning empty string (with if....or smt else)
           foreach (var hex in hexDigits)
           {
               int decValue = HexadecimalToDecimal(hex);
                // string binValue = DecimalToBinary(decValue);
                Console.WriteLine("{0} - {1}", hex, decValue); // hex to dec
                //Console.WriteLine("{0} - {1} - {2}", hex, decValue, binValue); // hex to dec and bin
               //Console.WriteLine("{2}'{0}', \"{1}\"{3}", hex, binValue.PadLeft(4,'0'), '{', '}'); // //hex to bin
               
           }
            //Console.WriteLine(HexToBinary("1A"));//Hex to bin
            //int decValue = -1;
            //string myHexNumber = decValue.ToString("X");
            //Console.WriteLine(myHexNumber); //signed decimal to HexaDecimal
        }
    }
}
