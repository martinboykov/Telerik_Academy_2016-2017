//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.
//Examples:

//a      b       c       biggest
//5	     2	     2	     5
//-2	-2	     1	     1
//-2	 4	     3	     4
//0	    -2.5	 5	     5
//-0.1	-0.5	-1.1	-0.1

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class TheBiggest3Numbers
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            string terminate;
            try
            {
                double a, b, c;
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                if (a > b & a > c)
                {
                    Console.WriteLine("The biggest nymber is: {0}", a);
                }
                else if (b > a & b > c)
                {
                    Console.WriteLine("The biggest nymber is: {0}", b);
                }
                else if (c > a & c > b)
                {
                    Console.WriteLine("The biggest nymber is: {0}", c);
                }
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                Console.WriteLine();
                terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                Console.WriteLine();
                terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}