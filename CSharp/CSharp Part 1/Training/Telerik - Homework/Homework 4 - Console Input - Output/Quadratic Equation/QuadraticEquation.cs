//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).

//Examples:

//a     b   c   roots
//2	    5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	    2	8	no real roots

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if ((Math.Pow(b, 2) - 4 * a * c) > 0)
        {
            Console.Write("roots are: \nx1 = {0}; ", (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
            Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) == 0)
        {
            Console.WriteLine("root is: x1 = x2 = {0}", (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
        Console.WriteLine();


        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        if ((Math.Pow(b, 2) - 4 * a * c) > 0)
        {
            Console.Write("roots are: \nx1 = {0}; ", (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
            Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) == 0)
        {
            Console.WriteLine("root is: x1 = x2 = {0}", (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
        Console.WriteLine();



        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        if ((Math.Pow(b, 2) - 4 * a * c) > 0)
        {
            Console.Write("roots are: \nx1 = {0}; ", (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
            Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) == 0)
        {
            Console.WriteLine("root is: x1 = x2 = {0}", (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
        Console.WriteLine();



        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        if ((Math.Pow(b, 2) - 4 * a * c) > 0)
        {
            Console.Write("roots are: \n x1 = {0}; ", (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
            Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) == 0)
        {
            Console.WriteLine("root is: x1 = x2 = {0}", (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
        Console.WriteLine();
    }
}

//  The example displays the following output:
//a = 2
//b = 5
//c = -3
//roots are: x1 = -3; x2 = 0.5