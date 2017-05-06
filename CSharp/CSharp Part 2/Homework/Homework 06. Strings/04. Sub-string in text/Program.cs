using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class Program
    {
        // Find all occurrences of a word within a text and return the indices of the occurrences
        static List<int> FindOccurrences(string text, string word)
        {
            var indices = new List<int>();

            int indexOfNextBacon = text.IndexOf(word);

            while (indexOfNextBacon != -1)
            {
                indices.Add(indexOfNextBacon);
                indexOfNextBacon = text.IndexOf(word, indexOfNextBacon + 1);
            }

            return indices;
        }

        static void Main()
        {
            var pattern = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower();
            var indices = FindOccurrences(text, pattern);
            //Console.WriteLine(string.Join(", ", indices));
            Console.WriteLine(indices.Count);
        }
    }
}
//string pattern = Console.ReadLine();
//string text = Console.ReadLine();

//var splitText = text.Split(new[] { pattern }, StringSplitOptions.None);
//Console.WriteLine(splitText.Length - 1);






//int count = 0;
//// Loop through all instances of the letter a.
//int i = 0;
//while ((i = text.IndexOf(pattern, i)) != -1)
//{
//    // Increment the index.
//    i++;
//    count++;
//}
//Console.WriteLine(count);