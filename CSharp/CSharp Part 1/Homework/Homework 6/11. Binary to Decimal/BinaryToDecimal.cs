//Binary to Decimal

//Description
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

//Input
//You will receive exactly one line containing an integer number representation in binary

//Output
//On the only output line write the decimal representation of the number

//Constraints
//All input numbers will be valid 32-bit integers
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input                         Output
//0	                            0
//11	                        3
//1010101010101011	            43691
//1110000110000101100101000000	236476736

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            char[] array = binary.ToCharArray();
            Array.Reverse(array);
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i] - '0';
                if (number == 1)
                {
                    double resultPow = Math.Pow(2, i);
                    result += resultPow;
                }
            }
            Console.WriteLine(result);
        }
    }
}
