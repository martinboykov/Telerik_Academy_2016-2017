namespace CSharpExam
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DeCatCoding
    {
        static void Main()
        {
            ulong inNumBase = 21;
            int outNumBase = 26;

            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                ulong num = ConvertToDecimal(words[i], inNumBase);
                string newWord = ConvertToString(num, outNumBase);
                sb.AppendFormat("{0} ", newWord);
            }
            //sb.length-- ( trim == sb.length--)
            Console.WriteLine(sb.ToString().Trim());
        }
        private static ulong ConvertToDecimal(string word, ulong inNumBase)
        {
            ulong result = 0;

            foreach (char digit in word)
            {
                result =((ulong)(digit - 'a') + result * inNumBase); //a is 97 in ACII  (от десетична 97  към символче 'а')  ( като ги сумираме)
            }
            
           
            return result;
        //    ulong res = 0;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        char ch = word[word.Length - 1 - i];
        //        res += (ulong)((ch - 'a') * Math.Pow(inNumBase, i));
        //    }
            

        //   return res;
        }
        private static string ConvertToString(ulong num, int numBase)
        {
            string res = "";
            while (num != 0)
            {
                char ch = (char)((int)(num % (ulong)numBase) + 'a');
                res = ch + res;
                num /= (ulong)numBase;
            }

            return res;
        }

        
    }
}
