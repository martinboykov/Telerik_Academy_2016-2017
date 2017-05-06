using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,] arr = new long[5, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };

            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);


                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}", arr[0, j]));
                }
                Console.Write(".");


        }
    }
}
