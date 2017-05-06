//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided(without remainder) by 7 and 5 at the same time.
//Examples:

//n Divided by 7 and 5?
//3	false
//0	true
//5	false
//7	false
//35 true
//140 true

using System;

class Divide
{
    static void Main()
    {
        int integerOne=3;
        Console.WriteLine((integerOne % 7==0) & ((integerOne % 5 == 0)));
        int integerTwo = 0;
        Console.WriteLine((integerTwo % 7 == 0) & ((integerTwo % 5 == 0)));
        int integerThree = 5;
        Console.WriteLine((integerThree % 7 == 0) & ((integerThree % 5 == 0)));
        int integerFour = 7;
        Console.WriteLine((integerFour % 7 == 0) & ((integerFour % 5 == 0)));
        int integerFive = 35;
        Console.WriteLine((integerFive % 7 == 0) & ((integerFive % 5 == 0)));
        int integerSix = 140;
        Console.WriteLine((integerSix % 7 == 0) & ((integerSix % 5 == 0)));

        //output:
        //false
        //true
        //false
        //false
        //true
        //true
    }
}