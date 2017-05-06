using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class SumOfnNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int N = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < N; i++)
        {
            double realNumber = double.Parse(Console.ReadLine());
            sum += realNumber;
        }
        Console.WriteLine(sum);
    }
}