//in BGCoder this Problem is named Eggcelent with slightly different conditions

using System;

class EasterMister
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        if (2 <= N && N <= 26 && N % 2 == 0)
        {
            //start of next pattern: +1
            int space = N + 1;
            for (int i = 0; i < N / 2; i++)
            {
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }

                if (i == 0) //if we are on 1st Row
                {
                    for (int star = 0; star < N - 1; star++)
                    {
                        Console.Write("*");
                    }
                }
                else //if we are on other then 1st Row
                {
                    Console.Write("*");
                    for (int dots = 0; dots < (N / 2) + ((i - 1) * 2); dots++)
                    {
                        Console.Write(".");
                    }


                    Console.Write(".");

                    for (int dots = 0; dots < (N / 2) + ((i - 1) * 2); dots++)
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
                space = space - 2;
            }
            //start of next pattern: +2
            for (int i = 0; i < (N / 2) - 1; i++)
            {
                Console.Write(".");
                Console.Write("*");
                for (int dots = 0; dots < N * 3 - 3; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                Console.Write(".");
                Console.WriteLine();
            }
            //start of the next pattern: +middle
            Console.Write(".");
            Console.Write("*");
            for (int dots = 0; dots < N * 3 - 3; dots++)
            {
                if (dots % 2 == 0)
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.Write("*");
            Console.Write(".");
            Console.WriteLine();
            //start of next Row
            Console.Write(".");
            Console.Write("*");
            for (int dots = 0; dots < N * 3 - 3; dots++)
            {
                if (dots % 2 == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("@");
                }
            }
            Console.Write("*");
            Console.Write(".");
            Console.WriteLine();
            //start of downwards patterns: -2
            for (int i = 0; i < (N / 2) - 1; i++)
            {
                Console.Write(".");
                Console.Write("*");
                for (int dots = 0; dots < N * 3 - 3; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                Console.Write(".");
                Console.WriteLine();
            }
            //start of next pattern: -1
            space = 3;
            for (int i = N / 2 - 1; i >= 0; i--)
            {
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }

                if (i == 0) //if we are on 1st Row
                {
                    for (int star = 0; star < N - 1; star++)
                    {
                        Console.Write("*");
                    }
                }
                else //if we are on other then 1st Row
                {
                    Console.Write("*");
                    for (int dots = 0; dots < (N / 2) + ((i - 1) * 2); dots++)
                    {
                        Console.Write(".");
                    } 
                    Console.Write(".");
                    for (int dots = 0; dots < (N / 2) + ((i - 1) * 2); dots++)
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
                space = space + 2;
            }

        }
    }
}