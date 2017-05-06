//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main()
    {
        int? variableOne = null;
        double? variableTwo = null;
        Console.WriteLine("variableOne={0} \nvariableTwo={1}", variableOne, variableTwo);
        variableOne = variableOne.GetValueOrDefault();
        variableTwo = variableTwo.GetValueOrDefault();
        Console.WriteLine("variableOne={0} \nvariableTwo={1}", variableOne, variableTwo);
    }
}