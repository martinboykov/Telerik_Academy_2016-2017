using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Labirinth_find_target
{
    class Program
    {
        static char[,] lab =
{
{' ', ' ', ' ', '*', ' ', ' ', ' '},
{'*', '*', ' ', '*', ' ', '*', ' '},
{' ', ' ', ' ', ' ', ' ', ' ', ' '},
{' ', '*', '*', '*', '*', '*', ' '},
{' ', ' ', ' ', ' ', ' ', ' ', 'е'},
};
        static void Main()
        {
            FindPath(0, 0);
        }
        static void FindPath(int row, int col)
        {
            if ((col < 0) || (row < 0) ||
            (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth
                return;
            }
            // Check if we have found the exit
            if (lab[row, col] == 'е')
            {
                Console.WriteLine("Found the exit!");
            }
            if (lab[row, col] != ' ')
            {
                // The current cell is not free
                return;
            }
            // Mark the current cell as visited
            lab[row, col] = 's';
            // Invoke recursion to explore all possible directions
            FindPath(row, col - 1); // left
            FindPath(row - 1, col); // up
            FindPath(row, col + 1); // right
            FindPath(row + 1, col); // down
                                   
            lab[row, col] = ' '; // Mark back the current cell as free (if we want to move back/ remove it if we dont)  //if we remove it the program becomes a lot faster
        }
    }
}
