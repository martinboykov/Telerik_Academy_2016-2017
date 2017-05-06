using System;
using System.Threading;
using System.Globalization;

class MoonGravity
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        double W = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F3}", W  * 0.17);
    }
}