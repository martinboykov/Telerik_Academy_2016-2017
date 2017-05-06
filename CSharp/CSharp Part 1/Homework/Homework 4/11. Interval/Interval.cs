using System;

class Interval
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        if ((0 <= N) && (N <= M) && (M <= 2000))
        {
            int countOne = 0;
            for (int i = N+1; i < M; i++)
            {
                if (i % 5 == 0)
                {
                    countOne++;
                }
            }
            Console.WriteLine("{0}", countOne);
        }
    }
}