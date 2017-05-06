//Problem 9. Sum of n Numbers
//
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//
//Note: You may need to use a for-loop.
//
//Examples:
//
//numbers      sum
//3	           90
//20	
//60	
//10	
//5	           6.5
//2	
//-1	
//-0.5	
//4	
//2	
//1	           1
//1

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class NumbersOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum = array.Sum();
        }
        Console.WriteLine(sum);
    }
}


//PS
//Да се помисли дали може да се измисли как да се избегне вкарването ръчно на брой на стойности в редицата!