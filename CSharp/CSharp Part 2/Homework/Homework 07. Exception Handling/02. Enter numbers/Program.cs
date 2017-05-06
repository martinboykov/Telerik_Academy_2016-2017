using System;

class ReadNumbers
{
    private static int ReadNumber(int start, int end)
    {
        if (start >= end )
        {
            throw new ArgumentException("Specified values do not represent a valid range.");
        }
        string inputValue = Console.ReadLine();
        int number = Int32.Parse(inputValue);
        return number;
    }

    static void Main()
    {
        int start = 1;
        int end = 100;
        int numbersCount = 10;
        int[] numbers = new int[12];
        numbers[0] = 1;
        numbers[11] = 100;
        for (int i = 1; i <= numbersCount; i++)
        {
            try
            {
                int number = ReadNumber(start, end);
                numbers[i] = number;
                if (numbers[i-1] >= numbers[i])
                {
                    throw new ArgumentException("the 1 < a1 < ... < a10 < 100 inequality is not true");
                }
                start = number;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Exception");
                Environment.Exit(0);
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == numbers.Length-1)
            {
                Console.Write("{0}", numbers[i]);
            }
            else
            {
                Console.Write("{0} < ", numbers[i]);
            }
        }
    }
}