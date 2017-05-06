using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double[] numbs = new double[3];
        int countNegative = 0;
        int countZero = 0;
        for (int i = 0; i < 3; i++)
        {
            numbs[i] = double.Parse(Console.ReadLine());
            if (numbs[i] == 0)
            {
                countZero++;
            }
            else if (numbs[i] < 0)
            {
                countNegative++;
            }
        }
        if (countZero > 0)
        {
            Console.WriteLine("0");
        }
        else if ((countNegative == 0) || (countNegative % 2 == 0))
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}