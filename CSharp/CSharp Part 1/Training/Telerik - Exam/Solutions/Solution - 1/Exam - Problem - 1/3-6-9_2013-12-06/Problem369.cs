﻿//Problem 1 – 3-6-9
//In secret services, they use very secret techniques to send encrypted secret messages.One such secret technique is sending secret texts as secret numbers secretly encoded with secret codes.Unfortunately the secret servant responsible for that particular secret technique is on secret vacation, so it is your duty to translate the secret messages.Since you are lazy scumbag (and that is no secret), you need to write a secret program, calculating the secret algorithm.Well, if you want, calculate it by hand but, you know, BGCoder will not be very happy!
//The secret algorithm accepts three numbers, one of which is a secret code, defining a mathematical (don’t hate us, math is a universal language) function for the other two.Afterwards, a magic number 3 appears in the calculations and distorts the answer.That’s all! Such a secret, isn’t it?
//You are given three secret numbers A, B, C, where B is actually the secret code symbol.
//•	If the code is 3 –find the sum of A and C.Example: A = 5, C = 3, A + C = 8.
//•	If the code is 6 –find the product of A and C.Example: A = 5, C = 3, A* C = 15.
//•	If the code is 9 –find the remainder after A is divided by C.Example: A = 5, C = 3, A % C = 2.
//After you find the result R from the code transformation, if R can be divided by 3 with remainder 0, find R divided by three.Otherwise find the remainder after R is divided by 3. 
//For example, if R is 15, it can be divided by 3 with no remainder, so the answer is 5. If R is 8, it cannot be divided by 3, so the answer is 2.

//Input
//The input data should be read from the console.
//On the first input line you will receive the positive integer A.
//On the second input line you will receive the positive integer B.
//On the third input line you will receive the positive integer C.
//The input data will always be valid and in the format described.There is no need to check it explicitly.

//Output
//The output should be printed on the console.
//If R can be divided by 3 with no remainder, on the first output line you should print R divided by 3.
//Otherwise, on the first output line you should print the remainder after R is divided by 3.
//On the second output line, you should print R.
//Constraints
//•	A, B and C will be positive integers between 1 and 999 999, inclusive.
//•	Allowed working time for your program: 0.10 seconds.Allowed memory: 16 MB.

//Examples
//Input example   Output example
//3               4
//6               12
//4	
//

//9	              1
//9               4
//5

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class Problem369
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long R = 0;
        if (B == 3)
        {
            R = A + C;
        }
        else if (B == 6)
        {
            R = A * C;
        }
        else if (B == 9)
        {
            R = A % C;
        }
        if (R % 3 == 0)
        {
            Console.WriteLine(R / 3);
        }
        else
        {
            Console.WriteLine(R % 3);
        }
        Console.WriteLine(R);
    }
}
