using System;
using System.Threading;
using System.Globalization;

class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F7}", (h * ((a + b) / 2)));
    }
}