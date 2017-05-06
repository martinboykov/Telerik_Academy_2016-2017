//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range[1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:

//score result
//2	    20
//4	    400
//9	    9000
//-1	invalid score
//10	invalid score

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class BonusScore
{
    static void Main()
    {
        int n = 0;
        Console.WriteLine("Enter number (n) between 1 and 9: ");
        n = int.Parse(Console.ReadLine());
        if (0 < n & n <= 9)
        {
            if (1 <= n & n <= 3)
            {
                n = n * 10;
                Console.WriteLine("result is: {0}", n);
            }
            else if (4 <= n & n <= 6)
            {
                n = n * 100;
                Console.WriteLine("result is: {0}", n);
            }
            else if (7 <= n & n <= 9)
            {
                n = n * 1000;
                Console.WriteLine("result is: {0}", n);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
        Console.WriteLine();



        Console.WriteLine("Enter number (n) between 1 and 9: ");
        n = int.Parse(Console.ReadLine());
        if (0 < n & n <= 9)
        {
            if (1 <= n & n <= 3)
            {
                n = n * 10;
                Console.WriteLine("result is: {0}", n);
            }
            else if (4 <= n & n <= 6)
            {
                n = n * 100;
                Console.WriteLine("result is: {0}", n);
            }
            else if (7 <= n & n <= 9)
            {
                n = n * 1000;
                Console.WriteLine("result is: {0}", n);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
        Console.WriteLine();


        Console.WriteLine("Enter number (n) between 1 and 9: ");
        n = int.Parse(Console.ReadLine());
        if (0 < n & n <= 9)
        {
            if (1 <= n & n <= 3)
            {
                n = n * 10;
                Console.WriteLine("result is: {0}", n);
            }
            else if (4 <= n & n <= 6)
            {
                n = n * 100;
                Console.WriteLine("result is: {0}", n);
            }
            else if (7 <= n & n <= 9)
            {
                n = n * 1000;
                Console.WriteLine("result is: {0}", n);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
        Console.WriteLine();

        Console.WriteLine("Enter number (n) between 1 and 9: ");
        n = int.Parse(Console.ReadLine());
        if (0 < n & n <= 9)
        {
            if (1 <= n & n <= 3)
            {
                n = n * 10;
                Console.WriteLine("result is: {0}", n);
            }
            else if (4 <= n & n <= 6)
            {
                n = n * 100;
                Console.WriteLine("result is: {0}", n);
            }
            else if (7 <= n & n <= 9)
            {
                n = n * 1000;
                Console.WriteLine("result is: {0}", n);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
        Console.WriteLine();

        Console.WriteLine("Enter number (n) between 1 and 9: ");
        n = int.Parse(Console.ReadLine());
        if (0 < n & n <= 9)
        {
            if (1 <= n & n <= 3)
            {
                n = n * 10;
                Console.WriteLine("result is: {0}", n);
            }
            else if (4 <= n & n <= 6)
            {
                n = n * 100;
                Console.WriteLine("result is: {0}", n);
            }
            else if (7 <= n & n <= 9)
            {
                n = n * 1000;
                Console.WriteLine("result is: {0}", n);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
        Console.WriteLine();
    }
}