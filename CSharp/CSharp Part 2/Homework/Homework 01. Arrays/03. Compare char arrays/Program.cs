using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArrayFirst = (Console.ReadLine()).ToCharArray();
            char[] charArraySecond = (Console.ReadLine()).ToCharArray();
            int shorterLength = 0;
            if (charArrayFirst.Length > charArraySecond.Length)
            {
                shorterLength = charArraySecond.Length;
            }
            else
            {
                shorterLength = charArrayFirst.Length;
            }
            for (int i = 0; i < shorterLength; i++)
            {
                if (charArrayFirst[i] > charArraySecond[i])
                {
                    Console.WriteLine(">");  Environment.Exit(0); break;
                }
                else if (charArrayFirst[i] < charArraySecond[i])
                {
                    Console.WriteLine("<"); Environment.Exit(0); break;
                }
            }
            if (charArrayFirst.Length > charArraySecond.Length)
            {
                Console.WriteLine(">"); 
            }
            else if (charArrayFirst.Length < charArraySecond.Length)
            {
                Console.WriteLine("<"); 
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}