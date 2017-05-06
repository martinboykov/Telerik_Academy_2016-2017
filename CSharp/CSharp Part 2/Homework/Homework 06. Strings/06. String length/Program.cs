using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine(); //"-=StringOfLength20=-";
            
            if (text.Length < 20)
            {
                while (text.Length < 20)
                {
                    text += "*";
                }
            }
            Console.WriteLine(text);
           
        }
    }
}

//string pattern = @"(\\|\n|\r|\t|\s)";
//string replacement = "";
//Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
//string result = rgx.Replace(text, replacement);

//StringBuilder sb = new StringBuilder(result.Length);
//sb.Append(result);
//            if (sb.Length< 20)
//            {
//                sb.Append('*', (20 - sb.Length));
//            }
//            if (sb.Length > 20)
//            {
//                sb.Remove(20-1, sb.Length);
//            }
//            result = sb.ToString();
//            Console.WriteLine(result);