//Hex to Decimal
//Description

//Using loops write a program that converts a hexadecimal integer number to its decimal form.

//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Input

//The input will consists of a single line containing a single hexadecimal number as string.
//Output

//The output should consist of a single line - the decimal representation of the number as string.
//Constraints

//All numbers will be valid 64-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input        Output
//FE	       254
//1AE3         6883
//4ED528CBB4   338583669684

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string hexValue = Console.ReadLine();
            long decValue = Convert.ToInt64(hexValue, 16);
            Console.WriteLine(decValue);
        }
    }
}