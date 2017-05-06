using System;
using System.Globalization;
using System.Text;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if ((Math.Pow(b, 2) - 4 * a * c) > 0)
        {
            double rootOne = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double rootTwo = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            if (rootOne>rootTwo)
            {
                Console.WriteLine("{0:F2}",rootTwo);
                Console.WriteLine("{0:F2}", rootOne);
            }
            else
            {
                Console.WriteLine("{0:F2}", rootOne);
                Console.WriteLine("{0:F2}", rootTwo);
            }
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) == 0)
        {
            Console.WriteLine("{0:F2}", (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}
