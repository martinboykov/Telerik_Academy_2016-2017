using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);
            double T = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double S = double.Parse(Console.ReadLine());
            double N = double.Parse(Console.ReadLine());

            double totalTails = T * B * S * N;
            if (totalTails % 2 == 0)
            {
                totalTails = T * B * S * N * 376439;
            }
            else
            {
                totalTails = T * B * S * N / 7;
            }
            Console.WriteLine("{0:F3}", totalTails);
        }
    }
}


//int n = int.Parse(Console.ReadLine());