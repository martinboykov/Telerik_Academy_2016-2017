//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:

//n    output
//3	   1 2 3
//5	   1 2 3 4 5

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class NumbersFrom1toN
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
                Console.Write( "n = ");
                int n = Int32.Parse(Console.ReadLine());
                Console.Write("The numbers from 1 to n are: ");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ",i);
                }
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Wrong input!\nPress 'enter' to try aggain or type 'exit' in the console to exit from the program!");

                terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}