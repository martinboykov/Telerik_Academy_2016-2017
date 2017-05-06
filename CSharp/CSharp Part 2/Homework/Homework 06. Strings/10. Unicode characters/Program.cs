using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Unicode_characters
{
    class Program
    {
        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
        static void Main(string[] args)
        {
            var text = Console.ReadLine();//"Hi!";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(GetEscapeSequence(text[i])); 
            }
            string output = sb.ToString();
            Console.Write(output);
        }
    }
}
