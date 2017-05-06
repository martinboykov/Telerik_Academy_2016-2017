using System;
using System.Text.RegularExpressions;

class Program
{
    private static bool Contains(string input, string wordToFind)
    {
        string pattern = String.Format(@"\b[^A-Z]?{0}[^A-Z]?\b", wordToFind);
        Match match = Regex.Match(input, pattern);
        return match.Success;
    }
    static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        string[] sentences = text.Split(new string[] { "...", "." , "!", "?" }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string sentence in sentences)
        {
            if (Contains(sentence, word))
            {
                Console.Write("{0}. ", sentence.TrimStart());
            }
        }

    }
}
//Regex.Split(text, @"(?<=[.])"

//@"\b{0}\b"
//We are living in a yellow submarine... We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.