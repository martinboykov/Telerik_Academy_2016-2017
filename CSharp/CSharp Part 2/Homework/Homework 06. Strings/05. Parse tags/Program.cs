using System;
using System.Collections.Generic;

class Program
{


    static void Main(string[] args)
    {
        var text = Console.ReadLine(); //"<upcase>yellow</upcase> We are living in a <upcase>yellow living submarine</upcase>. We don't have <upcase>anything</upcase> else <upcase>yellow living submarine</upcase>.";//
        var stack = new Stack<int>();
        int index;
        int startIndex;
        string output;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<' && text[i + "<upcase>".Length - 1] == '>')
            {
                index = i;
                string toCheck = text.Substring(i, "<upcase>".Length);
                if (toCheck == "<upcase>")
                {
                    stack.Push(index); i = i + "<upcase>".Length - 1;
                }
            }
            else if (text[i] == '<' && text[i + "</upcase>".Length - 1] == '>')
            {
                index = i;
                string toCheck = text.Substring(i, "</upcase>".Length);
                if (toCheck == "</upcase>")
                {
                    startIndex = stack.Pop();
                    int length = (index + "</upcase>".Length - 1) - startIndex + 1;
                    string toReplace = text.Substring(startIndex, length);
                    string toUpper = toReplace.ToUpper();
                    output = text.Replace(toReplace, toUpper);
                    text = output;
                    i = i + "</upcase>".Length - 1;
                }
            }
        }
        output = text.Replace("<UPCASE>", ""); text = output;
        output = text.Replace("</UPCASE>", "");
        Console.WriteLine(output);
    }
}

//// Input strings.
//string s1 = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";//Console.ReadLine();
//s1 = Regex.Replace(s1, @"<upcase>(.|\n|\r|\n\r)*?</upcase>", m => m.Value.ToUpper());
//            // . - Matches any single character except a newline character.
//            // \n - Matches a newline character.
//            // | - is used to ass и/или
//            string pattern = @"<upcase>|</upcase>";
//string replacement = "";
//Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
//string result = rgx.Replace(s1, replacement);
//Console.WriteLine(result);




//string value = "444 AND 4 44 4 44";

//// Get first match.
//Match match = Regex.Match(value, @"44");
//if (match.Success)
//{
//    Console.WriteLine(match.Value);
//}

//// Get second match.
//while (match.Success)
//{
//    match = match.NextMatch();
//    Console.WriteLine(match.Value);
//}
////match = match.NextMatch();
////if (match.Success)
////{
////    Console.WriteLine(match.Value);
////}





//public static class TextTools
//{
//    /// <summary>
//    /// Uppercase first letters of all words in the string.
//    /// </summary>
//    public static string Upper(string s)
//    {
//        return Regex.Replace(s, @"[<upcase>](\w+)[</upcase>]", delegate (Match match)
//        {
//            string v = match.ToString().ToUpper();
//            return  v;
//        });
//    }
//}

