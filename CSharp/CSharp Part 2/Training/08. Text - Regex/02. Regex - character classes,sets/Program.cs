using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _02.Regex___character_classes_sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string text = @"Anchors are a different breed. They do not match any character at all. Instead, they match a position before,
after or between characters. They can be used to “anchor” the regex match at a certain position. The caret «^»
matches the position before the first character in the string. Applying «^a» to “abc” matches „a”. «^b» will
not match “abc” at all, because the «b» cannot be matched right after the start of the string, matched by «^».
See below for the inside view of the regex engine.";
            MatchCollection matches = Regex.Matches(text, @"\b[^a-z]*[a-z]*[^a-z]*\b", RegexOptions.IgnoreCase | RegexOptions.Multiline); 
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
            
        }
    }
}
