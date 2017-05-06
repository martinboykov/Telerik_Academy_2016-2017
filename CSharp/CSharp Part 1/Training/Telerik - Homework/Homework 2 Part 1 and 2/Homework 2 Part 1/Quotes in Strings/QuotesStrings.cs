//Problem 7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class QuotesStrings
{
    static void Main()
    {
        string one = "The \"use\" of quotations causes difficulties";
        string two = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(one);
        Console.WriteLine(two);

        //Console print:
        //The "use" of quotations causes difficulties
        //The "use" of quotations causes difficulties
    }
}