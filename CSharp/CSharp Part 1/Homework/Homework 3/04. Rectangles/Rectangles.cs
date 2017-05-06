using System;
using System.Threading;
using System.Globalization;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2} {1:F2}", width * height , 2*width + 2*height);
    }
}