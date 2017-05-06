using System;
using System.Globalization;
using System.Threading;

class ComparingFloats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a < 0 && b > 0)
        {
            b = -b;
            if (Math.Abs(a - b) < 0.000001)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        else if (a > 0 && b < 0)
        {
            a = -a;
            if (Math.Abs(a - b) < 0.000001)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        else
        {
            if ((Math.Abs(a - b) < 0.000001))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}