//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:

//a     b     greater
//5	    6	  6
//10	5	  10
//0	    0	  0
//-5	-2	  -2
//1.5	1.6	  1.6

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + (a > b ? a : b) + "\n");

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + (a > b ? a : b) + "\n");

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + (a > b ? a : b) + "\n");

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + (a > b ? a : b) + "\n");

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + (a > b ? a : b) + "\n");
    }
}

// The example displays the following output:
//a = 5
//b = 6
//The greater number is: 6
//
//a = 10
//b = 5
//The greater number is: 10
//
//a = 0
//b = 0
//The greater number is: 0
//
//a = -5
//b = -2
//The greater number is: -2
//
//a = 1.5
//b = 1.6
//The greater number is: 1.6
//