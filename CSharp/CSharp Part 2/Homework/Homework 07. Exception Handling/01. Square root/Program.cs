using System;
using System.Globalization;
using System.Threading;

class SquareRoot
{
    public static double Sqrt(double n)
    {
        if (n < 0)
        {
            throw new FormatException("Invalid number");
        }

        return Math.Sqrt(n);
    }


    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        try
        {
            double n = double.Parse(Console.ReadLine());

            double sqrt = Sqrt(n);

            Console.WriteLine("{0:F3}", sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}