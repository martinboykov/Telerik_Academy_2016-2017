using System;
using System.Globalization;
using System.Text;
using System.Threading;

class ApplesOrangesBoth
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long sumEven = 0;
        long sumOdd = 0;
        long digit = 0;
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        if (0 < N & N < 10)
        {
            if (N % 2 == 0)
            {
                Console.WriteLine("apples {0}", N);
            }
            else
            {
                Console.WriteLine("oranges {0}", N);
            }
        }
        else if (N > 9)
        {
            for (long i = N; i > 0; i /= 10)
            {
                digit = i % 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
            }
        }
        if (sumEven > sumOdd)
        {
            Console.WriteLine("apples {0}", sumEven);
        }
        else if (sumEven < sumOdd)
        {
            Console.WriteLine("oranges {0}", sumOdd);
        }
        else if (sumEven == sumOdd)
        {
            Console.WriteLine("both {0}", sumOdd);
        }
    }
}