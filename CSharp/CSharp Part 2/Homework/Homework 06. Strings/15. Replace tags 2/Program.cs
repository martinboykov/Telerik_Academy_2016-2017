using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Replace_tags_1
{
    class Program
    {   //Console.ReadLine()
        //@"<p><a href=""http://academy.telerik.com"">our site</a>. Also <a href=""www.devbg.org"">our forum</a>.</p>"
       public static string ReadongMultilineText()
       {
            
            StringBuilder text = new StringBuilder();
            string input;
            while (!String.IsNullOrWhiteSpace(input = Console.ReadLine()))
            {
                //Console.WriteLine(input);
                text.AppendLine((FindandReplace(input)));
            }
            //string input = Console.ReadLine();
            //using (StringReader reader = new StringReader(input))
            //{
            //    string line = string.Empty;
            //    do
            //    {
            //        line = reader.ReadLine();
            //        if (line != null)
            //        {
            //            //Console.WriteLine(line);
            //            //Console.WriteLine(FindandReplace(line));
            //            text.AppendLine((FindandReplace(input)));
            //        }

            //    } while (line != null);
            //}
            return text.ToString().Trim();
        }


        static void Main(string[] args)
        {

            //string input = ReadongMultilineText();
            string input = Console.ReadLine();
            FindandReplace(input);
            Console.WriteLine(input);
            //using (StringReader reader = new StringReader(input))
            //{
            //    string line = string.Empty;
            //    do
            //    {
            //        line = reader.ReadLine();
            //        if (line != null)
            //        {
            //            //Console.WriteLine(line);
            //            Console.WriteLine(FindandReplace(line));
            //        }

            //    } while (line != null);
            //}

        }

        public static string FindandReplace(string line)
        {
            string pattern1 = @"<a href=""";
            string pattern2 = @""">";
            string pattern3 = @"</a>";
            StringBuilder text = new StringBuilder();
            text.Append(line);
            List<int> stack1 = (KMPSearch(pattern1, text.ToString()));
            List<int> stack2 = (KMPSearch(pattern2, text.ToString()));
            List<int> stack3 = (KMPSearch(pattern3, text.ToString()));
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
            //Console.WriteLine();
            ///////////////////////////////
            //Insert Brackets//////////////
            ///////////////////////////////

            while (stack1.Count > 0 && stack2.Count > 0 && stack3.Count > 0)
            {
                int index1 = stack1.Count - 1;
                int index2 = stack2.Count - 1;
                int index3 = stack3.Count - 1;
                while (stack1.Count > 0)
                {
                    if (stack1[index1] > stack2[index2])
                    {
                        stack1.RemoveAt(index1); index1 = stack1.Count - 1; continue;
                    }
                    break;
                }
                while (stack2.Count > 0)
                {
                    if (stack2[index2] > stack3[index3])
                    {
                        stack2.RemoveAt(index2); index2 = stack2.Count - 1; continue;
                    }
                    break;
                }
                while (stack3.Count > 0)
                {

                    if (index3 - 1 > 0 && stack3[index3 - 1] > stack2[index2])
                    {
                        stack3.RemoveAt(index3); index3 = stack3.Count - 1; continue;
                    }
                    break;
                }
                text.Insert(stack3[index3], "]");
                text.Insert(stack2[index2] + 2, "[");
                text.Insert(stack2[index2], ")");
                text.Insert(stack1[index1] + 9, "(");
                stack1.RemoveAt(index1);
                stack2.RemoveAt(index2);
                stack3.RemoveAt(index3);
            }
            //Console.WriteLine();
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
            //Console.WriteLine();
            ///////////////////////////////
            //Insert [TEXT] BEFORE (URL)///
            ///////////////////////////////

            while (stack1.Count > 0 && stack2.Count > 0 && stack3.Count > 0)
            {
                int index1 = stack1.Count - 1;
                int index2 = stack2.Count - 1;
                int index3 = stack3.Count - 1;
                while (stack1.Count > 0)
                {
                    if (stack1[index1] > stack2[index2])
                    {
                        stack1.RemoveAt(index1); index1 = stack1.Count - 1; continue;
                    }
                    break;
                }
                while (stack2.Count > 0)
                {
                    if (stack2[index2] > stack3[index3])
                    {
                        stack2.RemoveAt(index2); index2 = stack2.Count - 1; continue;
                    }
                    break;
                }
                while (stack3.Count > 0)
                {

                    if (index3 - 1 > 0 && stack3[index3 - 1] > stack2[index2])
                    {
                        stack3.RemoveAt(index3); index3 = stack3.Count - 1; continue;
                    }
                    break;
                }
                string insert = text.ToString(stack2[index2] + 2, stack3[index3] - stack2[index2] - 2);
                text.Insert(stack1[index1] + 9, insert);
                stack1.RemoveAt(index1);
                stack2.RemoveAt(index2);
                stack3.RemoveAt(index3);

            }
            //Console.WriteLine();
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
            //Console.WriteLine();
            ///////////////////////////////
            //REMOVE ADDITIONAL [TEXT]/////
            ///////////////////////////////


            while (stack1.Count > 0 && stack2.Count > 0 && stack3.Count > 0)
            {
                int index1 = stack1.Count - 1;
                int index2 = stack2.Count - 1;
                int index3 = stack3.Count - 1;
                while (stack1.Count > 0)
                {
                    if (stack1[index1] > stack2[index2])
                    {
                        stack1.RemoveAt(index1); index1 = stack1.Count - 1; continue;
                    }
                    break;
                }
                while (stack2.Count > 0)
                {
                    if (stack2[index2] > stack3[index3])
                    {
                        stack2.RemoveAt(index2); index2 = stack2.Count - 1; continue;
                    }
                    break;
                }
                while (stack3.Count > 0)
                {

                    if (index3 - 1 > 0 && stack3[index3 - 1] > stack2[index2])
                    {
                        stack3.RemoveAt(index3); index3 = stack3.Count - 1; continue;
                    }
                    break;
                }
                text.Remove(stack2[index2], stack3[index3] + 4 - stack2[index2]);
                text.Remove(stack1[index1], 9);
                stack1.RemoveAt(index1);
                stack2.RemoveAt(index2);
                stack3.RemoveAt(index3);
            }
            return text.ToString();
        }
        public static List<int> KMPSearch(string pattern, string text)
        {
            int n = text.Length;
            int m = pattern.Length;
            List<int> stack = new List<int>();

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
                    stack.Add(i - m + 1);
                    matched = fl[matched];
                }
            }
            return stack;
        }
    }
}