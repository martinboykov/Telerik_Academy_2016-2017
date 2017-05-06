// 08. Write a program that extracts from a given text all sentences containing given word.
//            Example: The word is "in". The text is:

//     We are living in a yellow submarine. We don't have anything else. Inside the 
//     submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//     The expected result is:

//     We are living in a yellow submarine.
//     We will move out of it in 5 days.

//     Consider that the sentences are separated by "." and the words – by non-letter symbols.


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var word = "in";
        var text = @"We are living  a yellow submarine in. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        List<string> list = new List<string>();
        StringReader reader = new StringReader(text.ToString());
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            list.Add(line); // Add to list.
            Console.WriteLine(line); // Write to console.
        }
        //string[] sentence = text.Split('.');
        //for (int i = 0; i < sentence.Length; i++)
        //{
        //    Match match = Regex.Match(sentence[i], @"\b[^A-Z]?" + word + @"[^A-Z]?\b", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        //    if (match.Success)
        //    {
        //        Console.Write(sentence[i] + ".");
        //    }
        //}
    }
}
//var word = Console.ReadLine(); 
//var text = Console.ReadLine();
//var word ="in";
//var text =@"We are living in a yellow submarine... We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
//@"\b[^A-Z]*"+ word + @"[^A-Z]*\b"


//var word = Console.ReadLine();
//var text = Console.ReadLine();

//string[] sentence = text.Split('.');
//        for (int i = 0; i<sentence.Length; i++)
//        {
//            Match match = Regex.Match(sentence[i], @"\b[^A-Z]?" + word + @"[^A-Z]?\b", RegexOptions.IgnoreCase | RegexOptions.Singleline);
//            if (match.Success)
//            {
//                Console.Write(sentence[i] + ".");
//            }
//        }