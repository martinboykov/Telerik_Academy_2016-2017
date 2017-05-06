using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.One_system_to_any_other
{
    class Program
    {
        static int inputBase = int.Parse(Console.ReadLine());
        static string input = Console.ReadLine().ToUpper();
        static int outputBase = int.Parse(Console.ReadLine());
        static Dictionary<BigInteger, char> decToHex = new Dictionary<BigInteger, char>()
        {
            {0 , '0'},
            {1 , '1'},
            {2 , '2'},
            {3 , '3'},
            {4 , '4'},
            {5 , '5'},
            {6 , '6'},
            {7 , '7'},
            {8 , '8'},
            {9 , '9'},
            {10 , 'A'},
            {11 , 'B'},
            {12 , 'C'},
            {13 , 'D'},
            {14 , 'E'},
            {15 , 'F'},
        };

        static Dictionary<char, BigInteger> hexToDec = new Dictionary<char, BigInteger>()
        {
            {'0', 0  },
            {'1', 1  },
            {'2', 2  },
            {'3', 3  },
            {'4', 4  },
            {'5', 5  },
            {'6', 6  },
            {'7', 7  },
            {'8', 8  },
            {'9', 9  },
            {'A', 10 },
            {'B', 11 },
            {'C', 12 },
            {'D', 13 },
            {'E', 14 },
            {'F', 15 },
        };

        static void Main(string[] args)
        {
            ToDecimal();
        }

        public static void ToDecimal()
        {
            BigInteger decimalNumber = 0;
            foreach (char item in input)
            {
                decimalNumber = hexToDec[item] + decimalNumber * inputBase;
            }
            DecToAny(decimalNumber) ;
        }

        static string DecToAny(BigInteger decimalNumber)
        {
            string result = "";
            do
            {
                BigInteger reminder = decimalNumber % outputBase;
                result = decToHex[reminder] + result;
                decimalNumber /= outputBase;
            } while (decimalNumber > 0);
            Console.WriteLine(result);
            return result;
        }

        
    }
}