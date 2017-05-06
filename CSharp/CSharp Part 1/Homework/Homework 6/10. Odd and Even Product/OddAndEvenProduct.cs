//Odd and Even Product

//Description
//You are given N integers(given in a single line, separated by a space).

//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

//Input
//On the first line you will receive the number N
//On the second line you will receive N numbers separated by a whitespace.

//Output
//If the two products are equal, output a string in the format "yes PRODUCT_VALUE", otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"

//Constraints
//N will always be a valid integer number in the range [4, 50]
//All input numbers from the second line will also be valid integers
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input        Output
//5
//2 1 1 6 3	   yes 6
//5
//4 3 2 5 2	   no 16 15

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10.Odd_and_Even_Product
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int N = int.Parse(Console.ReadLine());
            if (4<=N && N<=50)
            {
                long result1 = 1;
                long result2 = 1;
                string numberString = Console.ReadLine();
                string[] numbersArray = numberString.Split(' ');
                int[] numbers = Array.ConvertAll(numbersArray, int.Parse);
                for (int i = 1; i < N + 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        result1 *= numbers[i - 1]; //odd
                    }
                    else if (i % 2 == 0)
                    {
                        result2 *= numbers[i - 1]; //even
                    }
                }
                if (result1 == result2)
                {
                    Console.WriteLine("yes {0}", result1);
                }
                else
                {
                    Console.WriteLine("no {0} {1}", result1, result2);
                }
            }
            
        }
    }
}
