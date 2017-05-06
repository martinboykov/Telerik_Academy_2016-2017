//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:

//width    height     perimeter   area
//3	       4	      14	      12
//2.5	   3	      11	      7.5
//5	       5	      20	      25

using System;

class Rectangle
{
    static void Main()
    {
        decimal perimeterOne = (2m * (3m + 4m));
        Console.WriteLine(perimeterOne);
        decimal perimeterTwo = (2m * (2.5m + 3m));
        Console.WriteLine(perimeterTwo);
        decimal perimeterThree = (2m * (5m + 5m));
        Console.WriteLine(perimeterThree);
        decimal areaOne = (3m * 4m);
        Console.WriteLine(areaOne);
        decimal areaTwo = (2.5m * 3m);
        Console.WriteLine(areaTwo);
        decimal areaThree = (5m * 5m);
        Console.WriteLine(areaThree);

        //output
        //14
        //11
        //20
        //12
        //7.5
        //25
    }
}