using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.Forbidden_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var asterisks = "******************************";

            var forbiddenWords = new string[]
            {
                "Microsoft",
                "PHP",
                "CLR"
            };
            var text = @"PHP CLR MicrosoftMicrosoft announced its next generation PHP compiler today. It is based on.NET Framework 4.0 and is implemented as a dynamic language in CLR.
PHP CLR Microsoft";
            DateTime startTime = DateTime.Now;
            foreach (var swear in forbiddenWords)
            {
                text = text.Replace(swear, asterisks.Substring(0, swear.Length));
            }
            //Console.WriteLine(text);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("... done in {0} seconds", endTime - startTime); Console.WriteLine();
             startTime = DateTime.Now;
            foreach (var swear in forbiddenWords)
            {
                string output = Regex.Replace(text, swear, asterisks.Substring(0, swear.Length));
            }
            //Console.WriteLine(text);
             endTime = DateTime.Now;
            Console.WriteLine("... done in {0} seconds", endTime - startTime); Console.WriteLine();



        }
        
    }
}
