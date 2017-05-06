//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.As a result print the values a and b, separated by a space.
//Examples:

//a     b      result
//5	    2	   2 5
//3	    4	   3 4
//5.5	4.5	   4.5 5.5

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine();
        }
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        Console.WriteLine();

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine();
        }
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        Console.WriteLine();

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine();
        }
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        Console.WriteLine();

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine();
        }
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        Console.WriteLine();
    }
}