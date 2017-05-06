using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = Console.ReadLine();
            if (card == "2") Console.WriteLine("yes 2");
            else if (card == "3") Console.WriteLine("yes 3");
            else if (card == "4") Console.WriteLine("yes 4");
            else if (card == "5") Console.WriteLine("yes 5");
            else if (card == "6") Console.WriteLine("yes 6");
            else if (card == "7") Console.WriteLine("yes 7");
            else if (card == "8") Console.WriteLine("yes 8");
            else if (card == "9") Console.WriteLine("yes 9");
            else if (card == "10") Console.WriteLine("yes 10");
            else if (card == "J" || card == "j") Console.WriteLine("yes j");
            else if (card == "Q" || card == "q") Console.WriteLine("yes q");
            else if (card == "K" || card == "k") Console.WriteLine("yes k");
            else if (card == "A" || card == "a") Console.WriteLine("yes A");
            else Console.WriteLine("no {0}", card);
        }
    }
}