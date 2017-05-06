using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_largest_number
{
    class Program
    {
        static int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        static int number1 = numbers[0];
        static int number2 = numbers[1];
        static int number3 = numbers[2];

        static void Main(string[] args)
        {
            GetMax();
        }
        public static void GetMax()
        {
            int result = Math.Max(Math.Max(number1, number2), number3);
            Console.WriteLine(result); ;
        }
    }
}
