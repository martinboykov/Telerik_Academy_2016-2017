using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Encode_and_Decode
{
    class Program
    {
        static void Main()
        {
            string wordsRegex = @"[^\s\.!?,;:]+";
            string separatorsRegex = @"[\s\.!?,;:]+";
            string sentence = "C# is not C++, not PHP and not Delphi!";
            MatchCollection words = Regex.Matches(sentence, wordsRegex);
            MatchCollection separators = Regex.Matches(sentence, separatorsRegex);
            StringBuilder finalSentence = new StringBuilder();
            for (int i = 0; i < words.Count; i++)
            {
                finalSentence.Append(words[words.Count - 1 - i]);
                finalSentence.Append(separators[i]);
            }
            Console.WriteLine(finalSentence.ToString());
        }
    }
}
