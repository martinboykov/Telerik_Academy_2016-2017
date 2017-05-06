using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
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
            int frequenNumber = 0;
            int frequenNumberCount = 0;
            int mostFrequentNumber = 0;
            int mostFrequentNumberCount = 0;
            for (int index = 0; index < intArray.Length; index++)
            {
                for (int i = 0; i < intArray.Length; i++)
                {
                    frequenNumber = intArray[index];
                    if (frequenNumber == intArray[i])
                    {
                        frequenNumberCount++;
                    }
                }
                if (mostFrequentNumberCount < frequenNumberCount)
                {
                    mostFrequentNumberCount = frequenNumberCount;
                    mostFrequentNumber = frequenNumber;
                }
                frequenNumberCount = 0;
            }
            Console.WriteLine(mostFrequentNumber + " (" + mostFrequentNumberCount + " times)");
        }
    }
}
