﻿//Decimal to Hex

//Description
//Using loops write a program that converts an integer number to its hexadecimal representation.

//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

//Input
//On the first and only line you will receive an integer in the decimal numeral system.
//Output

//On the only output line write the hexadecimal representation of the read number.

//Constraints
//All numbers will always be valid 64-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input         Output
//254	        FE
//6883	        1AE3
//338583669684	4ED528CBB4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class DecimalToHex
    {
        static void Main()
        {
            long decValue = long.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("X");
            Console.WriteLine(hexValue);
        }
    }
}