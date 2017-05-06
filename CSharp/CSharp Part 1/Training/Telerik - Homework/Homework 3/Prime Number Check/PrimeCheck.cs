//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n(n ≤ 100) is prime(i.e.it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Examples:

// n        Prime?
// 1	    false
// 2	    true
// 3	    true
// 4	    false
// 9	    false
// 97	    true
// 51	    false
// -3	    false
// 0	    false

using System;

class PrimeCheck
{
    static void Main()
    {
        int integer = 1;
        Console.WriteLine((integer > 1) & (((integer !=2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0)))); //First checks if integer is > 1, then if is not equal to 2,3,5 and 7 and in the same time if 2,3,5 and 7 are factors of it.

        integer = 2;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));
        integer = 3;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));
        integer = 4;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));
        integer = 9;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));
        integer = 97;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));
        integer = 51;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));
        integer = -3;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));
        integer = 0;
        Console.WriteLine((integer > 1) & (((integer != 2) ^ (integer % 2 == 0)) & ((integer != 3) ^ (integer % 3 == 0)) & ((integer != 5) ^ (integer % 5 == 0)) & ((integer != 7) ^ (integer % 7 == 0))));

        //output:
        //false
        //true
        //true
        //false
        //false
        //true
        //false
        //false
        //false
    }
}