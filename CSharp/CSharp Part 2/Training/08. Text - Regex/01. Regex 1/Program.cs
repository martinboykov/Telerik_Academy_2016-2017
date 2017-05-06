using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Regex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = @"c:\temp\hjghjghj\jhkjhkjhk\kjk.jpg";
            //Match match = Regex.Match(link, @"(\w:\\)*\\\w*", RegexOptions.IgnoreCase);
            MatchCollection matches = Regex.Matches(link, @"\.\w*", RegexOptions.IgnoreCase);
            foreach (var match in matches)
            {
                    Console.WriteLine("{0}", match);
            }
            
        }
    }
}
