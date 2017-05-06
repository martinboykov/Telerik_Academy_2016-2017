using System;
using System.Globalization;
using System.Threading;

class Sort3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()); //add first number
        double b = double.Parse(Console.ReadLine()); //add second numbe
        double c = double.Parse(Console.ReadLine()); //add third number
        if ((a > b & a > c) || (a > b & a == c) || (a == b & a > c) || (a == b & a == c) && ((a > b & a < c) || (a < b & a > c) || (a < b & a == c) || (a == b & a < c) || (a == b & a == c)) && ((a < b & a < c) || (a == b & a < c) || (a < b & a == c) || (a == b & a == c)))
        {
            Console.Write("{0} ", a);
            if (b > c)
            {
                Console.Write("{0} ", b);
                Console.Write("{0}", c);
            }
            else
            {
                Console.Write("{0} ", c);
                Console.Write("{0}", b);
            }
        }
        else if ((b > a & b > c) || (b == a & b > c) || (b > a & b == c) && ((b > a & b < c) || (b < a & b > c) || (b == a & b < c)) && ((b < a & b < c) || (b < a & b == c) || (b == a & b < c)))
        {
            Console.Write("{0} ", b);
            if (a > c)
            {
                Console.Write("{0} ", a);
                Console.Write("{0}", c);
            }
            else
            {
                Console.Write("{0} ", c);
                Console.Write("{0}", a);
            }
        }
        else
        {
            Console.Write("{0} ", c);
            if (a > b)
            {
                Console.Write("{0} ", a);
                Console.Write("{0}", b);
            }
            else
            {
                Console.Write("{0} ", b);
                Console.Write("{0}", a);
            }
        }
    }
}