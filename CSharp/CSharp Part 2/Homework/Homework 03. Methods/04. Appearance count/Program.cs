using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static int N = int.Parse(Console.ReadLine());
        static int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
        static int X = int.Parse(Console.ReadLine());

        static void Main(string[] args)
        {
            RepetitionOfX();
        }
        public static void RepetitionOfX()
        {
            int result = numbers.Where(x => x == X).Count();
            PrintRepetitionCount(result);
        }
        public static void PrintRepetitionCount(int result)
        {
            Console.WriteLine(result);
        }
    }
}
