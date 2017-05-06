using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sumOfAllSums = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i%j==0)
                    {
                        if (j%2==0)
                        {
                            sumOfAllSums += j;
                        }
                    }
                }
            }
            Console.WriteLine(sumOfAllSums);
        }
    }
}

//int n = int.Parse(Console.ReadLine());
