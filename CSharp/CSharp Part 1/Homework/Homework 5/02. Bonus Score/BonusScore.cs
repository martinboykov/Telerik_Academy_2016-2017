using System;
using System.Globalization;
using System.Threading;

class BonusScore
{

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long n = long.Parse(Console.ReadLine());
        if ((n>=1) && (n <=3))
        {
            Console.WriteLine(n*10);
        }
        else if ((n >= 4) && (n <= 6))
        {
            Console.WriteLine(n * 100);
        }
        else if ((n >= 7) && (n <= 9))
        {
            Console.WriteLine(n * 1000);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}