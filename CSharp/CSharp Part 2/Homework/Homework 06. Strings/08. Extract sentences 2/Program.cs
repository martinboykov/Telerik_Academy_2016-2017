using System;
using System.Linq; // needed for Where()

class ExtractSentences
{
    static void Main()
    {
        string wordSearch = Console.ReadLine().Trim().ToLower();
        string text = Console.ReadLine();

        string[] sentences = text
            .Split(new string[] { ".", "!", "?", "..." }, StringSplitOptions.RemoveEmptyEntries);
        char[] separators = GetNonLetterSymbols(text);

        foreach (string sentence in sentences)
        {
            string[] words = sentence
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (word.Trim().ToLower() == wordSearch)
                {
                    Console.Write(sentence + ".");
                    break;
                }
            }
        }

    }

    private static char[] GetNonLetterSymbols(string input)
    {
        char[] symbols = input
            .Where(ch => !char.IsLetter(ch)) // needs System.Linq
            .Distinct() // removes all duplicate elements in a collection; returns only the distinct elements
            .ToArray();

        return symbols;
    }
}