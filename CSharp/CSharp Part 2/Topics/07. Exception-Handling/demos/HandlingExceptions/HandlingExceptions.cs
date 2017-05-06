using System;

class HandlingExceptions
{
    static long CalcSquareOfNumber(string str)
    {
        long value = int.Parse(str);
        return value * value;
    }
        static void Main()
    {
        while (true)
        {
            try
            {
                string s = Console.ReadLine();
                Console.WriteLine("You entered valid Int32 number {0}.", s);
                int.Parse(s);
                long square = CalcSquareOfNumber(s);
                Console.WriteLine("Square = {0}.", square);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big to fit in Int32!");
            }
        }
        Console.WriteLine("FInished!");
    }
}