using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regex___extract_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hi! My, man..... Whats up!";
            MatchCollection matches = Regex.Matches(text, @"[^\.!?]*" + @"[\.!?]*", RegexOptions.IgnoreCase);
            foreach (var match in matches)
            {
                Console.WriteLine("{0}", match.ToString().Trim());
            }
        }
    }
}
