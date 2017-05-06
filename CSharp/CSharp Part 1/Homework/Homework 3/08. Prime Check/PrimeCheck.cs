using System;
using System.Threading;
using System.Globalization;

class PrimeCheck
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        int N = int.Parse(Console.ReadLine());
        bool ifPrime = true;

        if (N > 0 && N <= 100)
        {
            if (N==1)
            {
                ifPrime = false;
            }
            if (N==2)
            {
                ifPrime = true;
            }
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    ifPrime = false;
                }
            }
        }
        else
        {
            ifPrime = false;
        }
        if (ifPrime)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
