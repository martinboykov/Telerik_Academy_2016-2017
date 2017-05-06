using System;
using System.Globalization;
using System.Threading;

class Program
{

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        if (A>B)
        {
            Console.WriteLine("{0} {1}", B, A);
        }
        else
        {
            Console.WriteLine("{0} {1}", A, B);
        }
    }
}