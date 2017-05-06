using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double S = (a + b + c) / 2;
            double area = Math.Sqrt(S*(S- a)*(S- b)*(S- c));
            Console.WriteLine("{0:F2}", area);
        }
    }
}
