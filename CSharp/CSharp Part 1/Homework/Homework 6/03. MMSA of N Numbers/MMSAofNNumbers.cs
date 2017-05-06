//MMSA(Min, Max, Sum, Average) of N Numbers
//Description

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).

//The input starts by the number N(alone in a line) followed by N lines, each holding an integer number.
//The output is like in the examples below.

//Input
//On the first line, you will receive the number N.
//On each of the next N lines, you will receive a single floating-point number.

//Output
//You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, the sum on the third and the average on the fourth, in the following format:
//min= 3
//max= 6
//sum= 9
//avg= 4.5

//Constraints
//1 <= N <= 1000
//All numbers will be valid floating-point numbers that will be in the range [-10000, 10000]
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input   Output
//3       min= 1
//2       max= 5
//5       sum= 8
//1	      avg= 2.67

//3       min= -1
//2       max= 4
//-1      sum= 5
//4	      avg= 1.67


using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class MMSAofNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        if ((1 <= n) && (n <= 1000))
        {
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("min=");
            Console.WriteLine("{0:F2}", numbers.Min());
            Console.Write("max=");
            Console.WriteLine("{0:F2}", numbers.Max());
            Console.Write("sum=");
            Console.WriteLine("{0:F2}", numbers.Sum());
            Console.Write("avg=");
            Console.WriteLine("{0:F2}", numbers.Average());
        }
    }
}