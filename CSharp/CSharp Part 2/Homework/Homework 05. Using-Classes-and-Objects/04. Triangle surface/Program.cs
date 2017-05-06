using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.Triangle_surface
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double length = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double area = (length * altitude) / 2;
            Console.WriteLine("{0:F2}",area);
        }
    }
}
