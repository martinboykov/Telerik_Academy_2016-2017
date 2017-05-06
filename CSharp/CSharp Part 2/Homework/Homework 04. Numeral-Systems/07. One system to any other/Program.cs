using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.One_system_to_any_other
{
    class Program
    {
        static int s;
        static int N;
        static int d;
        static string randomBase;

        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            // convert to binary
            //string binary = IntToString(N, new char[] { '0', '1' });

            // convert to hexadecimal
            string randomBase = IntToString(N,
                new char[] { '2', '3', '4', '5', '6', '7', '8', '9',
                         'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'});

           //// convert to hexavigesimal (base 26, A-Z)
           //string hexavigesimal = IntToString(N,
           //    Enumerable.Range('A', 26).Select(x => (char)x).ToArray());
           //
           //// convert to sexagesimal
           //string xx = IntToString(N,
           //    new char[] { '0','1','2','3','4','5','6','7','8','9',
           //'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
           //'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x'});
        }

        public static string IntToString(int value, char[] baseChars)
        {
            string result = string.Empty;

            int targetBase = baseChars.Length;

            do
            {
                result = baseChars[value % targetBase] + result;
                value = value / targetBase;
            }
            while (value > 0);

            return result;
        }

        /// <summary>
        /// An optimized method using an array as buffer instead of 
        /// string concatenation. This is faster for return values having 
        /// a length > 1.
        /// </summary>
        public static string IntToStringFast(int value, char[] baseChars)
        {
            // 32 is the worst cast buffer size for base 2 and int.MaxValue
            int i = 32;
            char[] buffer = new char[i];
            int targetBase = baseChars.Length;

            do
            {
                buffer[--i] = baseChars[value % targetBase];
                value = value / targetBase;
            }
            while (value > 0);

            char[] result = new char[32 - i];
            Array.Copy(buffer, i, result, 0, 32 - i);

            return new string(result);
        }
    }
}