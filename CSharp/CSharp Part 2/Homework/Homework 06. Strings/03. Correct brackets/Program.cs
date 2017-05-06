using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int countBracked = 0;
            bool ifCorrect = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    countBracked++;
                }
                if (str[i] == ')')
                {
                    countBracked--;
                }
                if (countBracked < 0)
                {
                    ifCorrect = false; break;
                }
                //if (str[i] == '(' && str[i+1] == ')' && (i+1)< str.Length)
                //{
                //    ifCorrect = false; break;
                //}

            }

            //foreach (char ch in str)
            //{
            //    if (ch == '(')
            //    {
            //        countBracked++;
            //    }
            //    if (ch == ')')
            //    {
            //        countBracked--;
            //    }
            //    if (countBracked<0)
            //    {

            //        ifCorrect = false; break;
            //    }
            //}
            if (countBracked > 0)
            {
                ifCorrect = false; 
            }
            if (ifCorrect)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
