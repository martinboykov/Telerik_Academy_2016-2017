using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReadNumberLastDigit(number));

        }
        public static string ReadNumberLastDigit(int number)
        {
            number %= 10;

            string result = null;
            switch (number)
            {
                case 0: result = "zero"; return result;
                case 1: result = "one"; return result;
                case 2: result = "two"; return result;
                case 3: result = "three"; return result;
                case 4: result = "four"; return result;
                case 5: result = "five"; return result;
                case 6: result = "six"; return result;
                case 7: result = "seven"; return result;
                case 8: result = "eight"; return result;
                case 9: result = "nine"; return result;
            }
            return result;
        }
    }
}