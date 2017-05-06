using System;
using System.Threading;
using System.Globalization;

class PointInCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if (Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)) <= 2)
        {
            Console.WriteLine("yes {0:F2}", Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2)));
        }
        else
        {
            Console.WriteLine("no {0:F2}", Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2)));
        }
    }
}