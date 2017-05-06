//Problem 7. Point in a Circle

//Write an expression that checks if given point(x, y) is inside a circle K({ 0, 0}, 2).
//Examples:

//x     y       inside
//0	    1	    true
//-2	0	    true
//-1	2	    false
//1.5	-1	    true
//-1.5	-1.5	false
//100	-30	    false
//0	    0	    true
//0.2	-0.8	true
//0.9	-1.93	false
//1	    1.655	true

using System;

class FourDigit
{
    static void Main()
    {
        decimal x = 0;
        decimal y = 1;
        bool check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2; //checks if point with coordinates (x,y) is inside the circle K({0,0},2)
        Console.WriteLine(check); //output: True

        x = -2;
        y = 0;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = -1;
        y = 2;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = 1.5m;
        y = -1m;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = -1.5m;
        y = -1.5m;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = 100m;
        y = -30m;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = 0m;
        y = 0m;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = 0.2m;
        y = -0.8m;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = 0.9m;
        y = -1.93m;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);

        x = 1m;
        y = 1.655m;
        check = Math.Abs(x) <= 2 && Math.Abs(y) <= 2;
        Console.WriteLine(check);
    }
}