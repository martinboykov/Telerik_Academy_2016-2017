using System;

class OddorEven
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (Math.Abs(N) % 2 == 0)
        {
            Console.WriteLine("even {0}", N);
        }
        else
        {
            Console.WriteLine("odd {0}", N);
        }
    }
}