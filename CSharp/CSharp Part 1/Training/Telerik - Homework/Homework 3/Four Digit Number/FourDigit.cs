//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
//Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba(in our example 1102).
//Puts the last digit in the first position: dabc(in our example 1201).
//Exchanges the second and the third digits: acbd(in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

//Examples:

//n             sum of digits       reversed        last digit in front      second and third digits exchanged
//2011	        4	                1102	        1201	                 2101
//3333	        12	                3333	        3333	                 3333
//9876	        30	                6789	        6987	                 9786

using System;

class FourDigit
{
    static void Main()
    {
        string integer = 2011.ToString();
        char[] chars = integer.ToCharArray();
        char firstChar = chars[0];
        int firstNumber = firstChar - '0';
        char secondChar = chars[1];
        int secondNumber = secondChar - '0';
        char thirdChar = chars[2];
        int thirdNumber = thirdChar - '0';
        char fourthChar = chars[3];
        int fourthNumber = fourthChar - '0';
        Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber);

        integer = 3333.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber);

        integer = 9876.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber);

        //ouput
        //4
        //12
        //30

        integer = 2011.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("\n{3}{2}{1}{0}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        integer = 3333.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{3}{2}{1}{0}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        integer = 9876.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{3}{2}{1}{0}\n", firstNumber, secondNumber, thirdNumber, fourthNumber);

        //ouput
        //1102
        //3333
        //6789

        integer = 2011.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{3}{0}{1}{2}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        integer = 3333.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{3}{0}{1}{2}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        integer = 9876.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{3}{0}{1}{2}\n", firstNumber, secondNumber, thirdNumber, fourthNumber);

        //ouput
        //1201
        //3333
        //6987

        integer = 2011.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{0}{2}{1}{3}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        integer = 3333.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{0}{2}{1}{3}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        integer = 9876.ToString();
        chars = integer.ToCharArray();
        firstChar = chars[0];
        firstNumber = firstChar - '0';
        secondChar = chars[1];
        secondNumber = secondChar - '0';
        thirdChar = chars[2];
        thirdNumber = thirdChar - '0';
        fourthChar = chars[3];
        fourthNumber = fourthChar - '0';
        Console.WriteLine("{0}{2}{1}{3}\n", firstNumber, secondNumber, thirdNumber, fourthNumber);

        //ouput
        //2101
        //3333
        //9786
    }
}