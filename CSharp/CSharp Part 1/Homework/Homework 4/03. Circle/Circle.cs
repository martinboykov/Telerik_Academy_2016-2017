//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r    perimeter   area
//2	   12.57	   12.57
//3.5  21.99	   38.48

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class Circle
{
    static void Main()
    {
        
        
        double r = double.Parse(Console.ReadLine()); //user gives value to variable 'r'

        //Calculate perimeter and area of circle for the given 'r' value
        Console.WriteLine("{0:F2} {1:F2}", 2 * Math.PI * r, Math.PI * Math.Pow(r, 2));
    }
}

// The example displays the following output:
//       for radius = 2
//       The perimeter of the circle is = 12.57
//       The area of the circle is = 12.57
//
//       for radius = 3.5
//       The perimeter of the circle is = 21.99
//       The area of the circle is = 38.48