using System;

class BatGoikoTower
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        if (2 <= N && N <= 39)
        {
            int j = 1;
            int space = N - 1;
            int count = 1;
            for (int i = 0; i < N; i++)
            {
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("/");
                if (i == j)
                {

                    for (int dots = 0; dots < i; dots++)
                    {
                        Console.Write("--");
                    }
                    count++;
                    j = count * (count + 1) / 2;
                }
                else
                {
                    for (int dots = 0; dots < i; dots++)
                    {
                        Console.Write("..");
                    }
                }
                Console.Write("\\");
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                space--;
            }
        }
    }
}
