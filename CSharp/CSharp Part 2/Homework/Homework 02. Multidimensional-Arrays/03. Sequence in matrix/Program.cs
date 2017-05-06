using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int M = numbers[0];
            int N = numbers[1];
            int[][] masiv;
            masiv = new int[M][];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            }
            byte count = 1;
            byte countMax = 1;
            //////////////////////////////////////////////////////////////////////
            //  COL CASE  ////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            for (int row = 0; row < masiv.Length; row++)
            {
                count = 1;
                for (int col = 0; col < masiv[row].Length - 1; col++)
                {
                    if (masiv[row][col] == masiv[row][col + 1])
                    {
                        count++;
                    }
                    if (count > countMax)
                    {
                        countMax = count;
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////
            //  ROW CASE  ////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            count = 1;
            int colCount = 0;
            for (int col = 0; col < N; col++, colCount++)
            {
                count = 1;
                for (int row = 0; row < masiv.Length - 1; row++)
                {
                    if (masiv[row][col] == masiv[row + 1][col])
                    {
                        count++;
                    }
                    if (count > countMax)
                    {
                        countMax = count;
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////
            //  DIAGONAL CASE  ///////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            //  SUB CASE OF DIAGONAL CASE - LEFT TO RIGTH ////////////////////////
            //////////////////////////////////////////////////////////////////////
            count = 1;
            int currentNumber = 0;
            int rowTemp = 0;
            int colTemp = 0;
            for (int row = 0; row < masiv.Length; row++)
            {
                for (int col = 0; col < masiv[row].Length; col++)
                {
                    count = 1;
                    if (row == 0 || col == 0)//if one of the rows or cols is boundary at min=0
                    {
                        rowTemp = row; colTemp = col;
                        currentNumber = masiv[rowTemp][colTemp]; //massive at boundary
                        rowTemp++; colTemp++; // + 1 -> next number on the diagonal
                        while (rowTemp <= M - 1 && colTemp <= N - 1)//if any of the rows or cols is boundary at max=(M or N)
                        {
                            if (masiv[rowTemp][colTemp] == currentNumber)
                            {
                                count++;
                            }
                            else
                            {
                                currentNumber = masiv[rowTemp][colTemp];
                                count = 1;
                            }
                            if (count > countMax)
                            {
                                countMax = count;
                            }
                            rowTemp++; colTemp++;
                        }
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////
            //  SUB CASE OF DIAGONAL CASE - RIGTH TO LEFT ////////////////////////
            //////////////////////////////////////////////////////////////////////
            count = 1;
            currentNumber = 0;
            rowTemp = 0;
            colTemp = 0;
            for (int row = 0; row < masiv.Length; row++)
            {
                for (int col = 0; col < masiv[row].Length; col++)
                {
                    count = 1;
                    if (row == 0 || col == N - 1)//if one of the rows or cols is boundary at min=0
                    {
                        rowTemp = row; colTemp = col;
                        currentNumber = masiv[rowTemp][colTemp]; //massive at boundary
                        rowTemp++; colTemp--; // + 1 -> next number on the diagonal
                        while (rowTemp <= M - 1 && colTemp >= 0)//if any of the rows or cols is boundary at max=(M or N)
                        {
                            if (masiv[rowTemp][colTemp] == currentNumber)
                            {
                                count++;
                            }
                            else
                            {
                                currentNumber = masiv[rowTemp][colTemp];
                                count = 1;
                            }
                            if (count > countMax)
                            {
                                countMax = count;
                            }
                            rowTemp++; colTemp--;
                        }
                    }
                }
            }
            Console.WriteLine(countMax);
        }
    }
}