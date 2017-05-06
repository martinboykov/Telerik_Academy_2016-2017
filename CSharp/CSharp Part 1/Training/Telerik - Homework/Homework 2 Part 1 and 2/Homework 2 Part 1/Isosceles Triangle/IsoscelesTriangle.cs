//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        string copyRight = "©";
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("{0,4}\n\n{0,3}{0,2}\n\n{0,2}{0,4}\n\n{0,0}{0,2}{0,2}{0,2}", copyRight);

        //Console print:
        //   ©

        //  © ©

        // ©   ©

        //© © © ©
    }
}