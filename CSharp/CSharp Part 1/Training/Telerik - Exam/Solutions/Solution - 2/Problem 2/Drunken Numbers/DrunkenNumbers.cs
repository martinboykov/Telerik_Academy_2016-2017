using System;
using System.Globalization;
using System.Text;
using System.Threading;

class DrunkenNumbers
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long length = 1;
        long right = 0;
        long left = 0;
        long CurrentNumber = 0;
        long lengthCurrentNumber = 0;
        for (long i = 0; i < N; i++)
        {
            CurrentNumber = long.Parse(Console.ReadLine());
            if (CurrentNumber < 0)
            {
                CurrentNumber = -1 * CurrentNumber;
            }
            lengthCurrentNumber = CurrentNumber;
            length = 1;
            while ((lengthCurrentNumber /= 10) >= 1)
            {
                length++;
            }
            for (long r = 0; r < length / 2; r ++)
            {
                right = right + CurrentNumber % 10;
                CurrentNumber = CurrentNumber / 10;
            }
            if (length % 2 != 0)
            {
                right = right + CurrentNumber % 10;
                left = left + CurrentNumber % 10;
                CurrentNumber = CurrentNumber / 10;
            }
            for (long l = 0; l < length / 2; l ++)
            {
                left = left + CurrentNumber % 10;
                CurrentNumber = CurrentNumber / 10;
            }
        }
        if (left > right)
        {
            Console.WriteLine("M {0}", left - right);
        }
        else if (left < right)
        {
            Console.WriteLine("V {0}", right - left);
        }
        else
        {
            Console.WriteLine("No {0}", right + left);
        }
    }
}