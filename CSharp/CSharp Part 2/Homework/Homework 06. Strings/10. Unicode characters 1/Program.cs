using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Unicode_characters_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hi";
            Regex.Replace(s, @"\u0020", m => ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString());
            Console.WriteLine(s);
        }
    }
}
