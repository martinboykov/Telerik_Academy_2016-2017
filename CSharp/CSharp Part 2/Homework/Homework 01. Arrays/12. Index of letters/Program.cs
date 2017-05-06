using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = (Console.ReadLine()).ToCharArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                int indexOfNumberX = Array.BinarySearch(alphabet, word[i]);
                Console.WriteLine(indexOfNumberX);
            }
        }
    }
}

//with Lists - much faster for big collections: http://www.dotnetperls.com/binarysearch
//    ------------------
//char[] word = (Console.ReadLine()).ToCharArray();
//char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
//List<char> wordList = new List<char>(word.ToList());
//List<char> alphabetList = new List<char>(alphabet.ToList());

//            for (int i = 0; i<wordList.Count; i++)
//            {
//                //int indexOfNumberX = Array.BinarySearch<char>(alphabet, word[i]);
//                int indexOfNumberX = alphabetList.BinarySearch(wordList[i]);
//Console.WriteLine(indexOfNumberX);
//            }