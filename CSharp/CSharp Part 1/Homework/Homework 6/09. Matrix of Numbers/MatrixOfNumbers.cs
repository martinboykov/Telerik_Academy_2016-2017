//Matrix of Numbers

//Description
//Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below.Use two nested loops.
//Challenge: achieve the same effect without nested loops

//Input
//The input will always consist of a single line, which contains the number N

//Output
//See the examples.

//Constraints
//1 <= N <= 20
//N will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//n = 2   matrix    n = 3     matrix    n = 4     matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MatrixOfNumbers
{
    static void Main()
    {
        int N;
        bool isNInt = int.TryParse(Console.ReadLine(), out N);
        int result = N;
        if (1 <= N & N <= 100)
        {
            for (int row = 1; row < N + 1; row++)
            {
                Console.Write("{0} ", row);
                for (int col = row + 1; col < N + row; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }

    }
}