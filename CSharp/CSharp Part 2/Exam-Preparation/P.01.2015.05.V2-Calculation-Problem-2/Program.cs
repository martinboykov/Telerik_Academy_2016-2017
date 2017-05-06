using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P._01._2015._05.V2_Calculation_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read input
            //2. convert every number to decimal value ---> mia to 6532 
            //3. sum all the numbers (sum in decimal) ----> (sum)
            //4. convert the sum to meow numeral system 
            //5. print the result


            //var catNumbers = Console.ReadLine().Split(); //with symbols (chars)
            //Console.WriteLine(string.Join("\r\n", catNumbers)); //to check if it reads properly
            //Console.WriteLine(MeowToDec(catNumbers[0]));
            //var catNumbers = Console.ReadLine().Split(' ').Select(MeowToDec).ToArray(); //selects all chars and converts them to int decimal
            //Console.WriteLine(catNumbers[0]);
            var sum = Console.ReadLine().Split(' ').Select(MeowToDec).Sum(); //selects all chars and converts them to int decimal and then sums(concatenates) them all 
            Console.WriteLine(sum);
            var anwser = DecimalToMeow(sum) + " = " + sum;
            Console.WriteLine(anwser);
        }

        static int MeowToDec(string meow) //получаваме от mea ----> 6532 (concatenated decimal digits)
        {
            int result = 0;

            foreach (char digit in meow)
            {
                result = (digit - 'a') + result * 23; //a is 97 in ACII  (от десетична 97  към символче 'а')  ( като ги сумираме)
            }
            return result;
        }
        static string DecimalToMeow(int decValue) //sums the input numbers in meow lenguage   (mia ----> mia) (grrrr miao miao  ---> htksw)
        {
            // better performance could be achieved by using indexing instead of concatanation
            string result = string.Empty;
            do
            {
                char digit = (char)('a' + (decValue % 23)); //от символче до десетична
                result = digit + result;//получаваме цифрите в обратен ред (by concatenation)
                decValue /= 23;

            } while (decValue > 0);

            return result;
        }

        
    }
}
