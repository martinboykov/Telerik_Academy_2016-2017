using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] intArray = new int[N];

            for (int i = 0; i < N; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = 0;
            int maxSum = 0;
            for (int index = 0; index < intArray.Length - 1; index++)
            {
                currentSum += intArray[index];
                for (int i = index + 1; i < intArray.Length; i++)
                {
                    currentSum += intArray[i];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                    
                }
                currentSum = 0;

            }
            
            Console.WriteLine(maxSum);
        }
    }
}