//Problem 10. Point Inside a Circle || Outside of a Rectangle

//Write an expression that checks for given point(x, y) if it is within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).
//Examples:

//x      y      inside K || outside of R
//1      2	    yes
//2.5	 2	    no
//0      1	    no
//2.5	 1	    no
//2      0	    no
//4      0	    no
//2.5	 1.5	no
//2      1.5	yes
//1      2.5	yes
//-100	 -100	no

using System;

class PointInsideOutside
{
    static void Main()
    {
        decimal xCircle = 1m;
        decimal yCircle = 1m;
        decimal rCircle = 1.5m;
        decimal xRectangleL = -1m;
        decimal xRectangleR = 5m;
        decimal yRectangleT = 1m;
        decimal yRectangleB = -1m;
        decimal x = 1;
        decimal y = 2;

        Console.WriteLine(((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no")); //Checks if in circle and outside rectangle (xRectangleR < x < xRectangleL and/or yRectangleT < y < yRectangleB), if both conditions are cetisfied returns "yes".

        x = 2.5m;
        y = 2;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = 0;
        y = 1;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = 2.5m;
        y = 1m;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = 2m;
        y = 0m;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = 4;
        y = 0;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = 2.5m;
        y = 1.5m;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = 2;
        y = 1.5m;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = 1;
        y = 2.5m;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        x = -100;
        y = -100;
        Console.WriteLine((((x - xCircle) * (x - xCircle)) + ((y - yCircle) * (x - xCircle)) < rCircle * rCircle) & (((x < xRectangleL || x > xRectangleR) || (y < yRectangleB || y > yRectangleT))) ? "yes" : "no");

        //output:
        //yes
        //no
        //no
        //no
        //no
        //no
        //no
        //yes
        //yes
        //no
    }
}