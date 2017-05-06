//Homework: Operators and Expressions
//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
//Examples:

//n Odd?
//3	true
//2	false
//-2 false
//-1 true
//0	false

using System;

class OddEven
{
    static void Main()
    {
        int integerOne = 3;
        int integerTwo = 2;
        int integerThree = -2;
        int integerFour = -1;
        int integerFive = 0;

        Console.WriteLine(integerOne + " is an odd number (True/False) = " + (integerOne % 2 != 0));
        Console.WriteLine(integerTwo + " is an odd number (True/False) = " + (integerTwo % 2 != 0));
        Console.WriteLine(integerThree + " is an odd number (True/False) = " + (integerThree % 2 != 0));
        Console.WriteLine(integerFour + " is an odd number (True/False) = " + (integerFour % 2 != 0));
        Console.WriteLine(integerFive + " is an odd number (True/False) = " + (integerFive % 2 != 0));

        //output:
        //3 is an odd number (True/False) = True
        //2 is an odd number (True/False) = False
        //-2 is an odd number (True/False) = False
        //-1 is an odd number (True/False) = True
        //0 is an odd number (True/False) = False
    }
}