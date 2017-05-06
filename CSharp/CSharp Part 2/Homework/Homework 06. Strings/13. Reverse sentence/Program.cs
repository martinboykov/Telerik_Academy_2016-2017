using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.Reverse_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            //var splitted = Regex.Split(sentence, @"(\w)").Select(r => r.AsEnumerable()).ToArray();
            //var reversed = splitted.Select(sp => sp.Reverse().ToArray());
            //var zipped = splitted.Zip(reversed, (a, b) => string.Join("", a.Select((c, i) => char.IsUpper(c) ? char.ToUpper(b[i]) : char.ToLower(b[i]))));
            //var result = string.Join("", zipped);
            //StringBuilder sb = new StringBuilder(sentence.Count());
            //for (int i  = sentence.Length-1; i  > 0; i--)
            //{
            //    sb.Append(sentence[i]); //sb.Append(" ");
            //}
            //string reverse = sb.ToString();
            //for (int i = reversed.Length - 1; i > 0; i--)
            //{
            //    Console.Write(reversed[i]);  //sb.Append(" ");
            //}
            string reversed = ReverseWordsB(sentence);
            Console.WriteLine(reversed);
            
        }
        public static string ReverseWordsA(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        public static string ReverseWordsB(string str)
        {
            return String.Join(" ", str.Split('.', ' ').Reverse()).ToString();
        }
        //public static string ReverseWordsC(string str)
        //{
        //    Regex rgx = new Regex(@"\w+");

        //}
        
    }
}
