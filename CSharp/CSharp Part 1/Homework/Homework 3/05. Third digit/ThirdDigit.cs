using System;
using System.Threading;
using System.Globalization;

class ThirdDigit
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        int N = int.Parse(Console.ReadLine());
        if (N > 99)
        {
            if ((N / 100) % 10 == 7)
            {
                Console.WriteLine("true ");
            }
            else
            {
                Console.WriteLine("false {0}", (N / 100) % 10);
            }
        }
        else
        {
            Console.WriteLine("false {0}", (N / 100) % 10);
        }
    }
}