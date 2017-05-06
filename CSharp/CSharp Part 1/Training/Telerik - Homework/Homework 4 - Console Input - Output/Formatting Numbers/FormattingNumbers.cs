//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a(0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console.Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
//Examples:

//a     b           c           result
//254	11.6	    0.5	        FE |0011111110| 11.60|0.500 |
//499	-0.5559	    10000	    1F3 |0111110011| -0.56|10000.000 |
//0	    3	        -0.1234	    0 |0000000000| 3.00|-0.123 |

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
        }
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        string binValue = Convert.ToString(a, 2);
        Console.WriteLine("result: {0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, binValue.PadLeft(10, '0'), b, c);

        Console.WriteLine();
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
        }
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        binValue = Convert.ToString(a, 2);
        Console.WriteLine("result: {0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, binValue.PadLeft(10, '0'), b, c);

        Console.WriteLine();
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
        }
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        binValue = Convert.ToString(a, 2);  
        Console.WriteLine("result: {0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, binValue.PadLeft(10, '0'), b, c);
    }
}

// The example displays the following output:
//a = 254
//b = 11.6
//c = 0.5
//result: FE |0011111110| 11.60|0.500 |
//repets the algorithm for other values