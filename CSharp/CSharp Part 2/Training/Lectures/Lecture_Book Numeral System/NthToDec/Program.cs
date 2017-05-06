using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthToDec
{
    class Program
    {
        static Dictionary<char, int> NToDec = new Dictionary<char, int>()
        {
        {'a', 0},
        {'2', 1},
        {'y', 2},
       // {'z', 3}, //or add it later as shown below
                 };
        static int NToDecimal(string nValue, int n)
        {
            int sum = 0;

            foreach (char digit in nValue)
            {
                sum = NToDec[digit] + sum*n;
            }
            return sum;
        }
        static void Main()
        {
            string nNumber = "22";
            char digit = 'z';
            int digitValue = 3;
            NToDec.Add(digit, digitValue);//add to Dictionary
            Console.WriteLine(NToDecimal(nNumber,16));
        }
    }
}
