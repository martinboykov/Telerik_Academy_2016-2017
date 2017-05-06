//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.Examples:
//character Valid card sign?
//5 	yes
//1 	no
//Q     yes
//q     no
//P     no
//10	yes
//500	no

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class CheckPlayCard
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] stringArray = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        for (int i = 1; i < 7; i++)
        {
            string s = Console.ReadLine();

            int pos = Array.IndexOf(stringArray, s);
            if (pos > -1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.WriteLine();
        }
    }
}