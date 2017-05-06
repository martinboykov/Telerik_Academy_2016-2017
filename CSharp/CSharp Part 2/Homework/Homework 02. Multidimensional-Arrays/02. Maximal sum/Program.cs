using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the matrix
            short[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => short.Parse(x)).ToArray();
            short[][] masiv;
            masiv = new short[numbers[0]][];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv [i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => short.Parse(x)).ToArray();
            }
            //Find the maximal sum platform of size 3 x 3
            short bestSum = short.MinValue;
            for (int row = 0; row < masiv.Length - 2; row++)
            {
                for (int col = 0; col < masiv[row].Length - 2; col++)
                {
                    short sum = (short)(masiv[row][col] + masiv[row][col + 1] + masiv[row][col + 2] + masiv[row + 1][col] + masiv[row + 1][col + 1] + masiv[row + 1][col + 2] + masiv[row + 2][col] + masiv[row + 2][col + 1] + masiv[row + 2][col + 2]);
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            // Print the result
            Console.WriteLine(bestSum);
        }
    }
}
//short[] numbers = Console.ReadLine()
//                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                            .Select(x => short.Parse(x))
//                            .ToArray();
//// Declare and initialize the matrix
//short[,] matrix = new short[numbers[0], numbers[1]];
//            for (short row = 0; row<matrix.GetLength(0); row++)
//            {
//                numbers = Console.ReadLine()
//                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                            .Select(x => short.Parse(x))
//                            .ToArray();
//                for (short col = 0; col<matrix.GetLength(1); col++)
//                {
//                    matrix[row, col] = numbers[col];
//                }
//            }
//            // Find the maximal sum platform of size 3 x 3
//            short bestSum = short.MinValue;
//short one = 1;
//short two = 2;
//            for (short row = 0; row<matrix.GetLength(0) - 2; row++)
//            {
//                for (short col = 0; col<matrix.GetLength(1) - 2; col++)
//                {
//                    short sum = (short)(matrix[row, col] + matrix[row, col + one] + matrix[row, col + two] +
//                              matrix[(row + one), col] + matrix[row + one, col + one] + matrix[row + one, col + two] +
//                              matrix[row + two, col] + matrix[row + 2, col + one] + matrix[row + two, col + two]);
//                    if (sum > bestSum)
//                    {
//                        bestSum = sum;
//                    }
//                }
//            }
//            // Print the result
//            Console.WriteLine(bestSum);