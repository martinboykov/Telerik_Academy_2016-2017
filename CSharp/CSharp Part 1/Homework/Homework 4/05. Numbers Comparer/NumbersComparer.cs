using System;
using System.Globalization;
using System.Text;
using System.Threading;

class NumbersComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        Console.WriteLine(A > B ? A : B);
    }
}