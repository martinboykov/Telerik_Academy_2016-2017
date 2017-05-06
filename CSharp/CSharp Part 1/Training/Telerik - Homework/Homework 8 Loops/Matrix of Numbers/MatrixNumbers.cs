//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n(1 ≤ n ≤ 20) and prints a matrix like in the examples below.Use two nested loops.
//Examples:

//n = 2   matrix    n = 3     matrix    n = 4     matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MatrixNumbers
{
    static void Main()
    {
        while (true)
        {
            int n;
            Console.Write("Enter the first number n:");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            double result = n;
            if (1 <= n & n <= 100)
            {
                for (int row = 1; row < n + 1; row++)
                {
                    Console.Write("{0} ", row);
                    for (int col = row + 1; col < n + row; col++)
                    {
                        Console.Write("{0} ", col);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue or Esc to exit the Program");
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else if (cki.Key != ConsoleKey.Enter)
                {
                    continue;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue or Esc to exit the Program");
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else if (cki.Key != ConsoleKey.Enter)
                {
                    continue;
                }
            }
        }

    }
}