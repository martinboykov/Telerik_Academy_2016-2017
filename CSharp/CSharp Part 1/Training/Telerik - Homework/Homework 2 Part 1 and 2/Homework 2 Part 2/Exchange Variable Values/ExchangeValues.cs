//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a={0} \nb={1}", a, b);

        //Console print:
        //a=5
        //b=10

        a = a ^ b; //now a is 15 and b is 10
        b = a ^ b; //now a is 15 but b is 5 (original value of a)
        a = a ^ b; //now a is 10 and b is 5, numbers are swapped
        Console.WriteLine("\na={0} \nb={1}", a, b);

        //Console print:
        //a=10
        //b=5
    }
}