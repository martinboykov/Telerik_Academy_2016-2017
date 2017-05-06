using System;

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1000; i++)
        {
            Console.WriteLine(i);
            i++;
            Console.WriteLine(-i);
        }
    }
}