//its reversed Kaspichania Boats 

using System;

class DiamondTrolls
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        if (3 <= N && N <= 27)
        {
            //start of next pattern: +1
            int space = N / 2 + 1;
            if (N % 2 == 0)
            {
                for (int i = 0; i < N / 2 + 1; i++)
                {
                    for (int dots = 0; dots < space; dots++)
                    {
                        Console.Write(".");
                    }
                    if (i == 0) //if we are on 1st Row
                    {
                        for (int star = 0; star < N / 2 - 1; star++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("*");
                        for (int star = 0; star < N / 2 - 1; star++)
                        {
                            Console.Write("*");
                        }
                    }
                    else //if we are on other then 1st Row
                    {
                        Console.Write("*");
                        for (int dots = 0; dots < N / 2 + i - 2; dots++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("*");

                        for (int dots = 0; dots < N / 2 + i - 2; dots++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("*");
                    }
                    for (int dots = 0; dots < space; dots++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                    space--;
                }
                for (int i = 0; i < N * 2 + 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < N / 2 + 1; i++)
                {
                    for (int dots = 0; dots < space; dots++)
                    {
                        Console.Write(".");
                    }

                    if (i == 0) //if we are on 1st Row
                    {
                        for (int star = 0; star < N; star++)
                        {
                            Console.Write("*");
                        }
                    }
                    else //if we are on other then 1st Row
                    {
                        Console.Write("*");
                        for (int dots = 0; dots < N / 2 + i - 1; dots++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("*");

                        for (int dots = 0; dots < N / 2 + i - 1; dots++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("*");
                    }
                    for (int dots = 0; dots < space; dots++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                    space--;
                }
                for (int i = 0; i < N * 2 + 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            space = 1;
            for (int i = 0; i < N - 1; i++)
            {
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int dots = 0; dots < N - 2 - i; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int dots = 0; dots < N - 2 - i; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                space++;
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int i = 0; i < N; i++)
            {
                Console.Write(".");
            }
        }
    }
}