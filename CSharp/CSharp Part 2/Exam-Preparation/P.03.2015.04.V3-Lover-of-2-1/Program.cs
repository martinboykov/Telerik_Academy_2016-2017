using System;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Xml;

namespace LoverOf2
{
    internal class LoverOf2Solution
    {
        private static int rows;
        private static int cols;
        private static int coef;

        static void Main()
        {
           Solve();
            
        }

        private static void Solve()
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            coef = Math.Max(rows, cols);
            int n = int.Parse(Console.ReadLine());
            var moves = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int row = rows - 1;
            int col = 0;

            bool[,] used = new bool[rows, cols];
            foreach (int move in moves)
            {
                int toRow = move / coef;
                int toCol = move % coef;

                while (row != toRow)
                {
                    used[row, col] = true;
                    //                    Console.WriteLine("({0}, {1})", row, col);
                    if (row < toRow)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }
                while (col != toCol)
                {
                    used[row, col] = true;
                    //                    Console.WriteLine("({0}, {1})", row, col);
                    if (col < toCol)
                    {
                        col++;
                    }
                    else
                    {
                        col--;
                    }
                }
                used[row, col] = true;
            }
            BigInteger sum = 0;

            for (int r = 0; r < used.GetLength(0); r++)
            {
                for (int c = 0; c < used.GetLength(1); c++)
                {
                    if (used[r, c])
                    {
                        sum += GetValue(r, c, rows);
                    }
                }
            }
            Console.WriteLine(sum);
        }

        private static BigInteger GetValue(int row, int col, int rows)
        {
            BigInteger sum = (BigInteger)Math.Pow(2, 1 * (rows - 1 - row + col));
            return sum;
            //return ((BigInteger)1) << (rows - row - 1 + col);
        }
    }
}