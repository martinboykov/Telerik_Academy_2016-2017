using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Replace_tags_1
{
    
    class Program //<p><a href="http://academy.telerik.com">our site</a>. Also <a href="www.devbg.org">our forum</a>.</p>
    {
        //public static string ReadongMultilineText()
        //{

        //    StringBuilder text = new StringBuilder();
        //    string input;
        //    while (!String.IsNullOrWhiteSpace(input = Console.ReadLine()))
        //    {
        //        //Console.WriteLine(input);
        //        text.AppendLine((FindandReplace(input)));
        //    }
        //    return text.ToString().Trim();
        //}
        
        static void Main(string[] args)
        {

            //string input = ReadongMultilineText();
            var input = Console.ReadLine();
            FindandReplace(input);
            
          
        }

        public static void FindandReplace(string line)
        {
            var text = new StringBuilder();
            text.Append(line);

            string pattern1 = @"<a href=""";
            string pattern2 = @""">";
            string pattern3 = @"</a>";

            Stack<int> stack1 = (KMPSearch(pattern1,text.ToString()));
            Stack<int> stack2 = (KMPSearch(pattern2,text.ToString()));
            Stack<int> stack3 = (KMPSearch(pattern3, text.ToString()));

            //foreach (var item in stack1)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in stack2)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in stack3)
            //{
            //    Console.WriteLine(item);
            //}
            ///////////////////////////////
            //Insert Brackets//////////////
            ///////////////////////////////
            while (stack1.Count > 0)
            {
                int index2 = stack2.Pop();
                text.Insert(stack3.Pop(), "]");
                text.Insert(index2 + 2, "[");
                text.Insert(index2, ")");
                text.Insert(stack1.Pop() + 9, "(");
            }
            //Console.WriteLine(text.ToString());
            stack1 = (KMPSearch(pattern1,text.ToString()));
            stack2 = (KMPSearch(pattern2,text.ToString()));
            stack3 = (KMPSearch(pattern3,text.ToString()));
            //foreach (var item in stack1)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in stack2)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in stack3)
            //{
            //    Console.WriteLine(item);
            //}
            ///////////////////////////////
            //Insert [TEXT] BEFORE (URL)///
            ///////////////////////////////
            while (stack1.Count > 0)
            {
                int index1 = stack2.Pop() + 2;
                int index2 = stack3.Pop();
                string insert = text.ToString(index1, index2 - index1);
                text.Insert(stack1.Pop() + 9, insert);
            }
            //Console.WriteLine(text.ToString());
            stack1 = (KMPSearch(pattern1, text.ToString()));
            stack2 = (KMPSearch(pattern2, text.ToString()));
            stack3 = (KMPSearch(pattern3, text.ToString()));
            //foreach (var item in stack1)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in stack2)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in stack3)
            //{
            //    Console.WriteLine(item);
            //}
            ///////////////////////////////
            //REMOVE ADDITIONAL [TEXT]/////
            ///////////////////////////////
            while (stack1.Count > 0)
            {
                int index1 = stack1.Pop();
                int index2 = stack2.Pop();
                text.Remove(index2, stack3.Pop() + 4 - index2);
                text.Remove(index1, 9);
            }

            Console.WriteLine(text);
        }
        public static Stack<int> KMPSearch(string pattern, string text)
        {
            int n = text.Length;
            int m = pattern.Length;
            Stack<int> stack = new Stack<int>();

            // precompute

            int[] fl = new int[m + 1];
            fl[0] = -1;

            for (int i = 1; i < m; i++)
            {
                int j = fl[i];
                while (j >= 0 && pattern[j] != pattern[i])
                {
                    j = fl[j];
                }
                fl[i + 1] = j + 1;
            }

            // search

            int matched = 0;
            for (int i = 0; i < n; i++)
            {
                while (matched >= 0 && text[i] != pattern[matched])
                {
                    matched = fl[matched];
                }

                matched++;

                if (matched == m)
                {
                    stack.Push(i - m + 1);
                    matched = fl[matched];
                }
            }
            return stack;
        }
    }
}