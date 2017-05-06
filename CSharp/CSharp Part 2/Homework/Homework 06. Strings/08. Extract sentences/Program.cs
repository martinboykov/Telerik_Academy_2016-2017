using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    
    static char[] Separators(string input)
    {
        
        char[] separators = input.Where(c => !char.IsLetter(c))
                                 .Distinct()
                                 .ToArray();
        return separators;
    }
    static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        //foreach (var item in sentences)
        //{
        //    Console.WriteLine(item);
        //}
        foreach (string sentence in sentences)
        {
            char[] separators = Separators(sentence);
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if ((words[i].ToLower().Trim() == word.ToLower()))
                {
                    Console.Write("{0}.", sentence.TrimStart()); break;
                }
            }
         
        }
    }
}

//var word = Console.ReadLine(); //"in";// 
//var text = Console.ReadLine(); //"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";//
//var s = text;
//var r = new Regex("[^.!?;]*" + @"\s" + word + @"\s" + "[^.!?;]*" + @"[\^|\!|\?|\.]");
//var m = r.Matches(s);
//var result = Enumerable.Range(0, m.Count).Select(index => m[index].Value).ToList();
//StringBuilder sb = new StringBuilder();
//            foreach (var item in result)
//            {
//                Console.Write("{0}", item);
//                //sb.Append(item); //.Trim()
//               // sb.Append(". ");
//            }
//           // sb.ToString();
//           // Console.WriteLine(sb);



//            static List<int> FindOccurrences(string text, string word)
//{
//    var indices = new List<int>();

//    int indexOfNextBacon = text.IndexOf(word);

//    while (indexOfNextBacon != -1)
//    {
//        indices.Add(indexOfNextBacon);
//        indexOfNextBacon = text.IndexOf(word, indexOfNextBacon + 1);
//    }

//    return indices;
//}
//static void Main(string[] args)
//{
//    var word = "in";// Console.ReadLine();
//    var text = "We are living in a yellow submarine! We don't have anything else. Inside the submarine is very tight? So we are drinking all the day! We will move out of it in 5 days.";//Console.ReadLine(); //
//                                                                                                                                                                                         //var r = new Regex(@"[\^|\!|\?|\.]");
//                                                                                                                                                                                         //string[] sentences = Regex.Split(text, @"[\^|\!|\?|\.]");
//                                                                                                                                                                                         //foreach (var sentence in sentences)
//                                                                                                                                                                                         //{
//                                                                                                                                                                                         //    Console.WriteLine(sentence);
//                                                                                                                                                                                         //}
//    var indices = FindOccurrences(text, " " + word + " ");
//    List<int> indexList = new List<int>();
//    //StringBuilder sb = new StringBuilder();
//    foreach (var index in indices)
//    {
//        indexList.Add(index);
//        //sb.Append(index);
//        //sb.Append("\n");
//    }
//    //sb.ToString();
//    for (int i = 0; i < indexList.Count; i++)
//    {
//        Console.WriteLine(indexList[i]);
//    }
//    int place = text.LastIndexOf("!", 36);
//    Console.WriteLine(place);
//            // Console.WriteLine(sb);
//            //Console.WriteLine(string.Join(", ", indices));
//            //string[] sentences = text.Split(new char[] { ' ' },
//            //       StringSplitOptions.None);
//            //foreach (var item in sentences)
//            //{
//            //    Console.WriteLine(item);
//            //}






//var regex = new Regex(@".*your text goes here.*");
//var text = "This is a Test 2. This is the sentence with 'your text goes here' xyz. The middle sentence is the one we want.";

//var texts = text.Split('.');
//foreach(var t in texts) {
//   if(regex.IsMatch(t)) {
//      Console.WriteLine(t.Trim());
//   }
//}