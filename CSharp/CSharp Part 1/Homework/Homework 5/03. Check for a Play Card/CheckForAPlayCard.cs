using System;
using System.Globalization;
using System.Threading;

class BonusScore
{

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J","Q", "K", "A" };
        int count = 0;
        for (int i = 0; i < cards.Length; i++)
        {
            if (input == cards[i])
            {
                count++;
            }
        }
        if (count>0)
        {
            Console.WriteLine("yes {0}", input);
        }
        else
        {
            Console.WriteLine("no {0}", input);
        }
    }
}
