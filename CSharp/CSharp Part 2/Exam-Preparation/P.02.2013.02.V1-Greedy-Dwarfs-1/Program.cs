using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solve();
        }

        public static void Solve()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int keysCount = int.Parse(Console.ReadLine());

            int[][] keys = new int[keysCount][];

            for (int i = 0; i < keysCount; i++)
            {
                keys[i] = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            }
            int result = FindMaxSum(numbers, keys);
            Console.WriteLine(result);
        }

        public static int FindMaxSum(int[] numbers, int[][] keys)
        {
            int bestSum = int.MinValue;
            for (int i = 0; i < keys.Length; i++)
            {
                int keySum = CalculateSum(numbers, keys[i]);
                if (keySum > bestSum)
                {
                    bestSum = keySum;
                }
            }

            return bestSum;
        }

        private static int CalculateSum(int[] numbers, int[] keys)
        {
            bool[] used = new bool[numbers.Length];
            int index = 0;

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (used[index])
                {
                    break;
                }
                used[index] = true;
                sum += numbers[index];
                index += keys[i % keys.Length];
                if (index < 0 || index >= numbers.Length)
                {
                    break;
                }
            }
            return sum;
        }


       
    }
}
