//Decimal to Binary
//Description

//Using loops write a program that converts an integer number to its binary representation.

//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Input

//On the only input line you will receive the decimal integer number.
//Output

//Output a single string - the representation of the input decimal number in it's binary representation.
//Constraints

//All numbers will always be valid 32-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class DecimalToBinary
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            long numberTemp = number;
            int count = 0;
            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (numberTemp > 0)
                {
                    numberTemp /= 2;
                    count++;
                }
                numberTemp = number;
                long[] array = new long[count];
                for (int i = 0; i < array.Length; i++)
                {
                    if (numberTemp % 2 == 0)
                    {
                        array[i] = 0;
                    }
                    else
                    {
                        array[i] = 1;
                    }
                    numberTemp /= 2;
                }
                Array.Reverse(array);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }
            }
        }
    }
}