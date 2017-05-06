using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);
            int S = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            int space = 9 + ((S - 10) / 2);
            int spaceTemp = space;

            Console.Write(new string(' ', 1)); spaceTemp = spaceTemp - 1;
            Console.Write(new string(c, 1)); spaceTemp = spaceTemp - 1;
            Console.Write(new string(' ', 1 + (S - 10) / 4)); spaceTemp = spaceTemp - (1 + (S - 10) / 4);
            Console.Write(new string(c, 1)); spaceTemp = spaceTemp - 1;
            Console.Write(new string(' ', spaceTemp)); spaceTemp = space;
            Console.WriteLine();
            for (int i = 1; i <= 1 + (S - 10) / 4; i++)
            {
                Console.Write(new string(' ', 1)); spaceTemp = spaceTemp - 1;
                Console.Write(new string(c, 3 + (S - 10) / 4)); spaceTemp = spaceTemp - (3 + (S - 10) / 4);
                Console.Write(new string(' ', spaceTemp)); spaceTemp = space;
                Console.WriteLine();
            }
            for (int i = 1; i <= 1 + (S - 10) / 4; i++)
            {
                Console.Write(new string(' ', 2)); spaceTemp = spaceTemp - 2;
                Console.Write(new string(c, 1 + (S - 10) / 4)); spaceTemp = spaceTemp - (1 + (S - 10) / 4);
                Console.Write(new string(' ', spaceTemp)); spaceTemp = space;
                Console.WriteLine();
            }
            for (int i = 1; i <= 2 + (S - 10) / 4; i++)
            {
                Console.Write(new string(' ', 1)); spaceTemp = spaceTemp - 1;
                Console.Write(new string(c, 3 + (S - 10) / 4)); spaceTemp = spaceTemp - (3 + (S - 10) / 4);
                if (i == (2 + (S - 10) / 4))
                {
                    Console.Write(new string(' ', 3)); spaceTemp = spaceTemp - 3;
                    Console.Write(new string(c, (2 + (S - 10) / 4))); spaceTemp = spaceTemp - (2 + (S - 10) / 4);
                }
                Console.Write(new string(' ', spaceTemp)); spaceTemp = space;
                Console.WriteLine();
            }
            for (int i = 1; i <= 4 + (S - 10) / 4; i++)
            {
                Console.Write(new string(c, 5 + (S - 10) / 4)); spaceTemp = spaceTemp - (5 + (S - 10) / 4);
                if (i != (4 + (S - 10) / 4))
                {
                    Console.Write(new string(' ', 2)); spaceTemp = spaceTemp - 2;
                }
                else
                {
                    Console.Write(new string(' ', 1)); spaceTemp = spaceTemp - 1;
                    Console.Write(new string(c, 1)); spaceTemp = spaceTemp - 1;
                    
                }
                Console.Write(new string(c, 1)); spaceTemp = spaceTemp - 1;
                Console.Write(new string(' ', spaceTemp)); spaceTemp = space;
                Console.WriteLine();
            }
            Console.Write(new string(' ', 1)); spaceTemp = spaceTemp - 1;
            Console.Write(new string(c, 6 + (S - 10) / 4)); spaceTemp = spaceTemp - (6 + (S - 10) / 4);
            Console.Write(new string(' ', spaceTemp)); 


        }
    }
}




//int n = int.Parse(Console.ReadLine());
