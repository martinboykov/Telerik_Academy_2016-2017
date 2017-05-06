using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(ReverseFloat(d)); 
        }
       public static string ReverseFloat(decimal d)
       {
           string reversedStr = new string(d.ToString().Reverse().ToArray());
           
           return reversedStr;
         
       }
    }
}
