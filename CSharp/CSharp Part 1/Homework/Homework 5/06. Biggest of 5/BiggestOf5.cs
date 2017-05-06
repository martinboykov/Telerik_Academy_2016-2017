using System;
using System.Globalization;
using System.Threading;

class BiggestOf5
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()); //add first number
        double b = double.Parse(Console.ReadLine()); //add second numbe
        double c = double.Parse(Console.ReadLine()); //add third number
        double d = double.Parse(Console.ReadLine()); //add forth number
        double e = double.Parse(Console.ReadLine()); //add fifth number
        if ((a > b && a > c && a > d && a > e) || (a == b && a > c && a > d && a > e) || (a > b && a == c && a > d && a > e) || (a > b && a > c && a == d && a > e) || (a > b && a > c && a > d && a == e) || (a == b && a == c && a > d && a > e) || (a == b && a > c && a == d && a > e) || (a == b && a > c && a > d && a == e) || (a > b && a == c && a == d && a > e) || (a > b && a == c && a > d && a == e) || (a > b && a > c && a == d && a == e) || (a == b && a == c && a == d && a > e) || (a == b && a == c && a > d && a == e) || (a > b && a == c && a == d && a == e) || (a == b && a == c && a == d && a == e))
        {
            Console.WriteLine(a);
        }
        else if ((b > a && b > c && b > d && b > e) || (b > a && b == c && b > d && b > e) || (b > a && b > c && b == d && b > e) || (b > a && b > c && b > d && b == e) || (b > a && b == c && b == d && b > e) || (b > a && b == c && b > d && b > d && b == e) || (b > a && b > c && b == d && b == e) || (b > a && b == c && b == d && b == e))
        {
            Console.WriteLine(b);
        }
        else if ((c > a && c > b && c > d && c > e) || (c > a && c > b && c == d && c > e) || (c > a && c > b && c > d && c == e) || (c > a && c > b && c == d && c == e))
        {
            Console.WriteLine(c);
        }
        else if ((d > a && d > b && d > c && d > e) || d > a && d > b && d > c && d == e)
        {
            Console.WriteLine(d);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine(e);
        }
    }
}