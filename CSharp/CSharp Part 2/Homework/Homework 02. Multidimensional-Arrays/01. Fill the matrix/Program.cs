using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char determine = char.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            switch (determine)
            {
                case 'a':
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = 1 + row + N * col;
                        }
                    }
                    break;
                case 'b':
                    int counter = 1;
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                matrix[row, col] = counter++;
                            }
                        }
                        else
                        {
                            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                            {
                                matrix[row, col] = counter++;
                            }
                        }
                    }
                    break;
                case 'c':
                    List<int> rowList = new List<int>();
                    for (int i = N - 1; i >= 0; i--)
                    {
                        for (int k = i; k <= N - 1; k++)
                        {
                            rowList.Add(k);
                        }
                    }
                    for (int i = N - 2; i >= 0; i--)
                    {
                        for (int k = 0; k <= i; k++)
                        {
                            rowList.Add(k);
                        }
                    }
                    List<int> colList = new List<int>();
                    for (int i = 0; i <= N - 1; i++)
                    {
                        for (int k = 0; k <= i; k++)
                        {
                            colList.Add(k);
                        }
                    }
                    for (int i = 1; i <= N - 1; i++)
                    {
                        for (int k = i; k <= N - 1; k++)
                        {
                            colList.Add(k);
                        }
                    }
                    for (int i = 1; i <= colList.Count; i++)
                    {
                        matrix[rowList[i-1], colList[i-1]] = i;
                    }
                    break;
                case 'd':
                    int start = 0;
                    int end = N;
                    int numbers = 1;
                    while (end - start >= 1)
                    {
                        for (int i = start; i < end; i++)
                        {
                            matrix[i, start] = numbers;
                            numbers++;
                        }
                        for (int p = start + 1; p < end; p++)
                        {
                            matrix[end - 1, p] = numbers;
                            numbers++;
                        }
                        for (int j = end - 2; j >= start; j--)
                        {
                            matrix[j, end - 1] = numbers;
                            numbers++;
                        }
                        for (int x = end - 2; x >= start + 1; x--)
                        {
                            matrix[start, x] = numbers;
                            numbers++;
                        }
                        start++;
                        end--;
                    }
                    break;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col != matrix.GetLength(1) - 1)
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


//C# Homework 06: 17. Spiral matrix 
//int size = int.Parse(Console.ReadLine());
//// Main Logic
//int[,] matrix = new int[size, size];
//int start = 0;
//int end = size;
//int numbers = 1;
//        while (end - start >= 1)
//        {
//            for (int i = start; i<end; i++)
//            {
//                matrix[start, i] = numbers;
//                numbers++;
//            }
//            for (int p = start + 1; p<end; p++)
//            {
//                matrix[p, end - 1] = numbers;
//                numbers++;
//            }
//            for (int j = end - 2; j >= start; j--)
//            {
//                matrix[end - 1, j] = numbers;
//                numbers++;
//            }
//            for (int x = end - 2; x >= start + 1; x--)
//            {
//                matrix[x, start] = numbers;
//                numbers++;
//            }
//            start++;
//            end--;
//        }

//        // Printing the matrix
//        Console.WriteLine();
//        for (int counter = 0; counter<size; counter++)
//        {
//            for (int counterTwo = 0; counterTwo<size; counterTwo++)
//            {
//                Console.Write(matrix[counter, counterTwo] + " ");
//            }
//            Console.WriteLine();
//        }