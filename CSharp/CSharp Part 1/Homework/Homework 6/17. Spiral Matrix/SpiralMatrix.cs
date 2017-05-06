//Spiral Matrix

//Description
//Write a program that reads from the console a positive integer number N(1 ≤ N ≤ 20) and prints a matrix holding the numbers from 1 to N* N in the form of square spiral like in the examples below.

//Input
//The input will always consist of a single line containing a single number - N.

//Output
//Output a spiral matrix as described below.

//Constraints
//N will always be a valid integer number.
//1 ≤ N ≤ 20
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input   Output
//2	      1 2
//        4 3
//3	      1 2 3
//        8 9 4
//        7 6 5
//4	       1  2  3  4
//        12 13 14  5
//        11 16 15  6
//        10  9  8  7

using System;

class SpiralMatrix
{
    static void Main()
    {
        // Input
        int size = int.Parse(Console.ReadLine());
        // Main Logic
        int[,] matrix = new int[size, size];
        int start = 0;
        int end = size;
        int numbers = 1;
        while (end - start >= 1)
        {
            for (int i = start; i < end; i++)
            {
                matrix[start, i] = numbers;
                numbers++;
            }
            for (int p = start + 1; p < end; p++)
            {
                matrix[p, end - 1] = numbers;
                numbers++;
            }
            for (int j = end - 2; j >= start; j--)
            {
                matrix[end - 1, j] = numbers;
                numbers++;
            }
            for (int x = end - 2; x >= start + 1; x--)
            {
                matrix[x, start] = numbers;
                numbers++;
            }
            start++;
            end--;
        }

        // Printing the matrix
        Console.WriteLine();
        for (int counter = 0; counter < size; counter++)
        {
            for (int counterTwo = 0; counterTwo < size; counterTwo++)
            {
                Console.Write(matrix[counter, counterTwo] + " ");
            }
            Console.WriteLine();
        }
    }
}