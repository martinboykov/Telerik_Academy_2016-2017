using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_area_in_matrix
{
    class Program
    {
        static short[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => short.Parse(x)).ToArray();
        static short rows = numbers[0];
        static short cols = numbers[1];
        static short[] numbersMatrix;
        static short[,] matrix = new short[rows, cols];
        static bool[,] matrixBoolChecked = new bool[rows, cols];
        static short count = 0;
        static short maxCount = 0;
        static short currentIndex = 0;


        static void Main()
        {
            for (int row = 0; row < numbers[0]; row++)
            {
                numbersMatrix = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => short.Parse(x)).ToArray();
                for (int col = 0; col < numbers[1]; col++)
                {
                    matrix[row, col] = numbersMatrix[col];
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    currentIndex = matrix[row, col];
                    if (matrixBoolChecked[row, col] == false)
                    {
                        FindPath(row, col);
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    
                }
            }
            Console.WriteLine(maxCount);
        }
        static void FindPath(int row, int col)
        {
            if ((col < 0) || (row < 0) || (col >= cols) || (row >= rows))
            {
                // We are out of the matrixyrinth
                return;
            }
            if (matrixBoolChecked[row, col] == true)
            {
                // Not to call recursion if a given cell is visited
                return;
            }
            // Check if we have found the exit
            if (matrix[row, col] == currentIndex)
            {
                matrixBoolChecked[row, col] = true;
                count++;
            }
            if (matrix[row, col] == currentIndex)
            {
                // Invoke recursion to explore all possible directions
                FindPath(row, col - 1); // left
                FindPath(row - 1, col); // up
                FindPath(row, col + 1); // right
                FindPath(row + 1, col); // down
            }
        }
    }
}
