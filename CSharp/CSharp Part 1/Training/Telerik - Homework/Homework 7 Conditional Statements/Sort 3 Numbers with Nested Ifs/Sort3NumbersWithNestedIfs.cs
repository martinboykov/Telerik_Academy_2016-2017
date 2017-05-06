//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

//Examples:

//a      b       c       result
//5	     1	     2	     5      2     1
//-2	-2	     1	     1     -2    -2
//-2	 4	     3	     4      3    -2
//0	    -2.5     5	     5      0    -2.5
//-1.1	-0.5    -0.1	-0.1   -0.5  -1.1
//10	 20	     30	     30     20    10
//1	     1	     1	     1      1     1

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class Sort3NumbersWithNestedIfs
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
                if ((a > b & a > c) || (a > b & a == c) || (a == b & a > c) || (a == b & a == c))
                {
                    Console.Write(a + " ");
                }
                else if ((b > a & b > c) || (b == a & b > c) || (b > a & b == c))
                {
                    Console.Write(b + " ");
                }
                else if ((c > a & c > b) || (c > a & c == b) || (c == a & c > b))
                {
                    Console.Write(c + " ");
                }


                if (((a > b & a < c) || (a < b & a > c) || (a < b & a == c) || (a == b & a < c) || (a == b & a == c)))
                {
                    Console.Write(a + " ");
                }
                else if ((b > a & b < c) || (b < a & b > c) || (b == a & b < c))
                {
                    Console.Write(b + " ");
                }
                else if ((c > a & c < b) || (c < a & c <a) || (c == a & c < b) || (c < a & c == b))
                {
                    Console.Write(c + " ");
                }

                if ((a < b & a < c) || (a == b & a < c) || (a < b & a == c) || (a == b & a == c))
                {
                    Console.Write(a + " ");
                }
                else if ((b < a & b < c) || (b < a & b == c) || (b == a & b < c))
                {
                    Console.Write(b + " ");
                }
                else if ((c < a & c < b) || (c == a & c < b) || (c < a & c == b))
                {
                    Console.Write(c + " ");
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

//--------------------------------------------------------
//More efficient solution to the problem is the following:
//--------------------------------------------------------
//
//using System;
//using System.Globalization;
//using System.Text;
//using System.Threading;

//class Sort3NumbersWithNestedIfs
//{
//    static void Main()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//        while (true)
//        {
//            string terminate;
//            try
//            {
//                double a, b, c;
//                Console.Write("a = ");
//                a = double.Parse(Console.ReadLine());
//                Console.Write("b = ");
//                b = double.Parse(Console.ReadLine());
//                Console.Write("c = ");
//                c = double.Parse(Console.ReadLine());

//                double[] numbers = { a, b, c };
//                Array.Sort(numbers);
//                Array.Reverse(numbers);
//                foreach (double number in numbers)
//                {
//                    Console.Write(number + " ");
//                }
//                Console.WriteLine();
//                Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
//                Console.WriteLine();
//                terminate = Console.ReadLine();
//                if (terminate == "exit")
//                {
//                    Environment.Exit(0);
//                }
//            }
//            catch (Exception)
//            {
//                Console.WriteLine();
//                Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
//                Console.WriteLine();
//                terminate = Console.ReadLine();
//                if (terminate == "exit")
//                {
//                    Environment.Exit(0);
//                }
//            }
//        }
//    }
//}