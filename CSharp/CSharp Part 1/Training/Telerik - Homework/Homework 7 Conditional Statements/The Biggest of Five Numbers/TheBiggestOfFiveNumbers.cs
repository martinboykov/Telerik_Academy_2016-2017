//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:

//a      b       c       d   e       biggest
//5	     2	     2	     4	 1	     5
//-2	-22	     1	     0	 0	     1
//-2	 4	     3	     2	 0	     4
//0	    -2.5	 0	     5	 5	     5
//-3	-0.5	-1.1	-2	-0.1	-0.1

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class TheBiggestOfFiveNumbers
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
                double a, b, c, d, e;
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                Console.Write("d = ");
                d = double.Parse(Console.ReadLine());
                Console.Write("e = ");
                e = double.Parse(Console.ReadLine());
                if ((a > b & a > c & a > d & a > e) || (a == b & a > c & a > d & a > e) || (a > b & a == c & a > d & a > e) || (a > b & a > c & a == d & a > e) || (a > b & a > c & a > d & a == e) || (a == b & a == c & a > d & a > e) || (a == b & a > c & a == d & a > e) || (a == b & a > c & a > d & a == e) || (a > b & a == c & a == d & a > e) || (a > b & a == c & a > d & a == e) || (a > b & a > c & a == d & a == e)||(a == b & a == c & a == d & a > e)|| (a == b & a == c & a > d & a == e)|| (a > b & a == c & a == d & a == e)|| (a == b & a == c & a == d & a == e))
                {
                    Console.WriteLine("The biggest nymber is: {0}", a);
                }

                else if ((b > a & b > c & b > d & b > e) || (b > a & b == c & b > d & b > e) || (b > a & b > c & b == d & b > e) || (b > a & b > c & b > d & b == e) || (b > a & b == c & b == d & b > e) || (b > a & b == c & b > d & b > d & b == e) || (b > a & b > c & b == d & b == e) || (b > a & b == c & b == d & b == e))
                {
                    Console.WriteLine("The biggest nymber is: {0}", b);
                }

                else if ((c > a & c > b & c > d & c > e) || (c > a & c > b & c == d & c > e)|| (c > a & c > b & c > d & c == e)||(c > a & c > b & c == d & c == e))
                {
                    Console.WriteLine("The biggest nymber is: {0}", c);
                }

                else if ((d > a & d > b & d > c & d > e)|| d > a & d > b & d > c & d == e)
                {
                    Console.WriteLine("The biggest nymber is: {0}", d);
                }
                else if (e > a & e > b & e > c & e > d)
                {
                    Console.WriteLine("The biggest nymber is: {0}", e);
                }
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
//using System.Linq;
//using System.Text;
//using System.Threading;

//class TheBiggestOfFiveNumbers
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
//                double a, b, c, d, e;
//                Console.Write("a = ");
//                a = double.Parse(Console.ReadLine());
//                Console.Write("b = ");
//                b = double.Parse(Console.ReadLine());
//                Console.Write("c = ");
//                c = double.Parse(Console.ReadLine());
//                Console.Write("d = ");
//                d = double.Parse(Console.ReadLine());
//                Console.Write("e = ");
//                e = double.Parse(Console.ReadLine());

//                double[] numbers = { a, b, c, d, e };
//                double max = numbers.Max();
//                Console.WriteLine(max);
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