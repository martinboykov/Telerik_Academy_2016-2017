using System;
using System.Globalization;
using System.Threading;

class BiggestOf3
{

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()); //add first number
        double b = double.Parse(Console.ReadLine()); //add second number
        double c = double.Parse(Console.ReadLine()); //add third number
        if ((a > b && a > c) || (a > b && a == c) || (a == b && a > c) || (a == b & a == c) && ((a > b && a < c) || (a < b && a > c) || (a < b && a == c) || (a == b && a < c) || (a == b && a == c)) && ((a < b && a < c) || (a == b && a < c) || (a < b && a == c) || (a == b && a == c)))
        {
            Console.Write(a);
        }
        else if ((b > a && b > c) || (b == a && b > c) || (b > a && b == c) && ((b > a && b < c) || (b < a && b > c) || (b == a && b < c)) && ((b < a && b < c) || (b < a && b == c) || (b == a && b < c)))
        {
            Console.Write(b);
        }
        else
        {
            Console.Write(c);
        }
    }
}