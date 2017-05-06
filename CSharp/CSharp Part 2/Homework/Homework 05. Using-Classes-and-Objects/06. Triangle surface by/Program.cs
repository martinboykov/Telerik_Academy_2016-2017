using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angleDegrees = double.Parse(Console.ReadLine());
            double angleRadians = Math.PI * angleDegrees / 180.0;
            double sinAngle = Math.Sin(angleRadians);
            double area = (a * b * sinAngle) / 2;
            Console.WriteLine("{0:F2}", area);
        }
    }
}
