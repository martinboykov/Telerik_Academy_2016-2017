using System;

class TheHorror
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] textArray = text.ToCharArray();
        int count = 0;
        foreach (char c in text)
            count++;
        int countChange = count;
        int countDigits = 0;
        int sumDigits = 0;
        for (int i = count; i > 0 ; i--)
        {
            bool checkDigit = char.IsDigit(textArray[i-1]);
            if (checkDigit == true & i % 2 != 0)
            {
                int digit = Convert.ToInt32(textArray[i-1]) - '0';
                sumDigits = sumDigits + digit;
                ++countDigits;
            }
        }
        Console.Write(countDigits + " ");
        Console.WriteLine(sumDigits);
    }
}