using System;

class FireInTheMatrix
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        if (4 <= N && N <= 76 && N % 4 == 0)
        {
            int space = (N / 2) - 1;
            for (int i = 0; i < N / 2; i++)
            {
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int dots = 0; dots < i; dots++)
                {
                    Console.Write("..");
                }
                Console.Write("#");
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                space--;
                //start of the mirror print
            }
            space = (N / 2) - 1;
            for (int i = 0; i < N / 4; i++)
            {
                for (int dots = 0; dots < i; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write("..");
                }
                Console.Write("#");
                for (int dots = 0; dots < i; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                space--;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            space = 0;
            int unicode = 92;
            char character = (char)unicode;
            string text = character.ToString();
            for (int i = 0; i < N / 2; i++)
            {
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                for (int j = 0; j < N / 2 - space; j++)
                {
                    Console.Write(text);
                }
                for (int j = 0; j < N / 2 - space; j++)
                {
                    Console.Write("/");
                }
                for (int dots = 0; dots < space; dots++)
                {
                    Console.Write(".");
                }
                space++;
                Console.WriteLine();
            }
        }
    }
}