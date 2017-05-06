using System;

class NthBit
{
    static void Main()
    {
        int p = Int32.Parse(Console.ReadLine());
        int n = byte.Parse(Console.ReadLine());
        bool zeroOrOne = false;
        if (p >= 0 && p <= Math.Pow(2, 55))
        {
            int mask = (int)((long)1 << n);
            int result = (p & mask);
            if (result == 0)
            {
                zeroOrOne = true;
            }
            Console.WriteLine(zeroOrOne ? "0" : "1");
        }
    }
}