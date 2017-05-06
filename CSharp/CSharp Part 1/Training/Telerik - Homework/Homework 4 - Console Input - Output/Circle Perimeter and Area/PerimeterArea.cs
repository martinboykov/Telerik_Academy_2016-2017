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

class PerimeterArea
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double r = 0; //'r' is the radius of the circle
        Console.Write("r = ");
        r = double.Parse(Console.ReadLine()); //user gives value to variable 'r'

        //Calculate perimeter and area of circle for the given 'r' value
        Console.WriteLine("The perimeter of the circle is = {0}", Math.Round(2 * Math.PI * r, 2));
        Console.WriteLine("The area of the circle is = {0}", Math.Round(Math.PI * Math.Pow(r, 2), 2));
        Console.WriteLine();

        Console.Write("r = ");
        r = double.Parse(Console.ReadLine()); //user gives value to variable 'r'

        Console.WriteLine("The perimeter of the circle is = {0}", Math.Round(2 * Math.PI * r, 2));
        Console.WriteLine("The area of the circle is = {0}", Math.Round(Math.PI * Math.Pow(r, 2), 2));
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