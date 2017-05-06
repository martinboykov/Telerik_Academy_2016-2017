//Problem 4. Multiplication Sign

//Write a program that shows the sign(+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

//a      b       c      result
//5	     2	     2	    +
//-2	-2	     1	    +
//-2	 4	     3	    -
//0	    -2.5	 4	    0
//-1	-0.5	-5.1	-

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c;

        while (true)
        {
            try
            {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("The result is: 0");
                    Console.WriteLine();
                }
                else if (a < 0 & b < 0 & c < 0)
                {
                    Console.WriteLine("The result is: -");
                    Console.WriteLine();
                }
                else if (a < 0 & b > 0 & c > 0)
                {
                    Console.WriteLine("The result is: -");
                    Console.WriteLine();
                }
                else if (a > 0 & b < 0 & c > 0)
                {
                    Console.WriteLine("The result is: -");
                    Console.WriteLine();
                }
                else if (a > 0 & b > 0 & c < 0)
                {
                    Console.WriteLine("The result is: -");
                    Console.WriteLine();
                }
                else if (a < 0 & b < 0 & c > 0)
                {
                    Console.WriteLine("The result is: +");
                    Console.WriteLine();
                }
                else if (a > 0 & b < 0 & c < 0)
                {
                    Console.WriteLine("The result is: +");
                    Console.WriteLine();
                }
                else if (a < 0 & b > 0 & c < 0)
                {
                    Console.WriteLine("The result is: +");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The result is: +");
                    Console.WriteLine();
                }
                Console.WriteLine("Use 'enter' key to try aggain or type 'exit' in the console to exit from the program!");
                Console.WriteLine();
                string terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }
            }

            catch (Exception )
            {
                Console.WriteLine("Use 'enter' key to try aggain or type 'exit' in the console to exit from the program!");
                Console.WriteLine();
                string terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}