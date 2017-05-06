//BitSwap

//Description

//Write a program first reads 4 numbers n, p, q and k and than swaps bits { p, p+1, …, p+k-1}
//with bits { q, q+1, …, q+k-1}
//of n.Print the resulting integer on the console.


//Input

//On the only four lines of the input you will receive the integers n, p, q and k in this order.

//Output

//Output a single value - the value of n after the bit swaps.

//Constraints

//The first and the second sequence of bits will never overlap.
//n will always be a valid 32-bit positive integer.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input           Binary representation                     Binary representation after swaps       Output
//1140867093                                              
//3                                                       
//24                                                      
//3	              01000100 00000000 01000000 00010101     	01000010 00000000 01000000 00100101	    1107312677
//4294901775                                              
//24                                                      
//3                                                       
//3	              11111111 11111111 00000000 00001111     	11111001 11111111 00000000 00111111	    4194238527
//2369124121
//2
//22
//10	          10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001  	1907751121

using System;
using System.Threading;
using System.Globalization;

class BitSwap
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
CultureInfo.InvariantCulture;
        long n = Int64.Parse(Console.ReadLine());
        long nSwap = n;
        byte p = byte.Parse(Console.ReadLine());
        byte q = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());
        if (n >= 0)
        {
            for (int i = 0; i < k; i++, p++, q++)
            {
                //assign bit at position  p  to bit at position  q
                if ((n & (1 << p)) == 0)
                {
                    nSwap = (nSwap & ~(1 << q));
                }
                else if ((n & (1 << p)) > 0)
                {
                    nSwap = (nSwap | (1 << q));
                }
                //assign bit at position  q  to bit at position  p
                if ((n & (1 << q)) == 0)
                {
                    nSwap = (nSwap & ~(1 << p));
                }
                else if ((n & (1 << q)) >  0)
                {
                    nSwap = (nSwap | (1 << p));
                }
                //increase j with +1
            }
            Console.WriteLine(nSwap);
        }
    }
}