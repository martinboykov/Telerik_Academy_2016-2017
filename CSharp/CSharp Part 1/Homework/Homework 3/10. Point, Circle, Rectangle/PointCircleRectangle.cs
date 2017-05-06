using System;
using System.Threading;
using System.Globalization;

class PointCircleRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool insideCircle = (Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2)) <= 1.5);
        bool insideRectangle = ((x >= -1) & (x <= 5) & (y >= -1) & (y <= 1));
        if (insideCircle && insideRectangle)
        {
            Console.WriteLine("inside circle inside rectangle");
        }
        else if (insideCircle && !insideRectangle)
        {
            Console.WriteLine("inside circle outside rectangle");
        }
        else if (!insideCircle && insideRectangle)
        {
            Console.WriteLine("outside circle inside rectangle");
        }
        else if (!insideCircle && !insideRectangle)
        {
            Console.WriteLine("outside circle outside rectangle");
        }
    }
}