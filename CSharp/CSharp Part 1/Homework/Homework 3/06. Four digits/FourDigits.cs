using System;
using System.Threading;
using System.Globalization;

class FourDigits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 10 + n / 10 % 10 + n / 100 % 10 + n / 1000 % 10);
        Console.WriteLine("{3}{2}{1}{0}", n / 1000 % 10, n / 100 % 10, n / 10 % 10, n % 10);
        Console.WriteLine("{3}{0}{1}{2}", n / 1000 % 10, n / 100 % 10, n / 10 % 10, n % 10);
        Console.WriteLine("{0}{2}{1}{3}", n / 1000 % 10, n / 100 % 10, n / 10 % 10, n % 10);
    }
}