using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
            PrintHigherNumberCount(ChecksHigherNumbers(numbers, N));
        }
        public static int ChecksHigherNumbers(int[] numbers, int N)
        {
            int index = -1;
            for (int i = 1; i <= numbers.Length - 2; i++)
            {

                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    index = i; break;
                }
                if (index == 0)
                {
                    index = -1;
                } 
            }
            return index;
        }
        public static void PrintHigherNumberCount(int result)
        {
            int count = result;
            Console.WriteLine(count);
        }
    }
}
