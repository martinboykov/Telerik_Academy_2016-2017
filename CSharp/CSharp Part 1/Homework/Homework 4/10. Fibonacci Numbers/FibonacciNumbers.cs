using System;

class FibonacciNumbers
{
    static void Main()
    {
        {

            long i, N, f1 = 0, f2 = 1, f3 = 0;
            N = long.Parse(Console.ReadLine());
            if (N == 1)
            {
                Console.Write("{0}", f1);
            }
            else if ((N > 1) && (N <= 50))
            {
                Console.Write("{0}, ", f1);
                Console.Write("{0}, ", f2);
                for (i = 2; i < N; i++)
                {
                    if (i == N - 1)
                    {
                        f3 = f1 + f2;
                        Console.Write("{0}", f3);
                    }
                    else
                    {
                        f3 = f1 + f2;
                        Console.Write("{0}, ", f3);
                        f1 = f2;
                        f2 = f3;
                    }

                }
            }
            Console.WriteLine();
        }
    }
}