using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    //<p>........<a href="http://academy.telerik.com">our site</a> ................ ..... <a href="www.devbg.org">our forum</a> .............</p>
    //<p>........[our site](http://academy.telerik.com).......................... ....... [our forum](www.devbg.org).........................</p>

    static string checkAhref;
    static string http;
    static string output;
    //var stack = new Stack<int>();
    
    static void Main(string[] args)
    {
        var text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            //Console.WriteLine(text[i]);
            GetMeOutOfHere:
            if (text[i] == '<')
            {
                if (i + @"<a href=""".Length < text.Length)
                {
                    string checkAhref = text.Substring(i, @"<a href=""".Length);
                    if (checkAhref == @"<a href=""")
                    {
                        short httpStart = (short)(i + @"<a href=""".Length);
                        for (int j = httpStart; j < text.Length; j++)
                        {
                            //Console.WriteLine(text[j]);
                            if (text[j] == '"' && text[j + 1] == '>' && j + 1 < text.Length)
                            {
                                string http = text.Substring(httpStart, (j - 1) - httpStart + 1);
                                j++;
                                short ourSiteForumStart = (short)(httpStart + http.Length + 2);
                                for (int k = ourSiteForumStart; k < text.Length; k++)
                                {
                                    //Console.WriteLine(text[k]);
                                    if (text[k] == '<' && text[k + 1] == '/' && text[k + 2] == 'a' && text[k + 3] == '>' && k + 3 < text.Length)
                                    {
                                        string ourSiteForum = text.Substring(ourSiteForumStart, (k) - ourSiteForumStart);
                                        if (ourSiteForum == "our site" || ourSiteForum == "our forum")
                                        {
                                            short lengthAll = (short)((ourSiteForumStart + ourSiteForum.Length + 3) - i + 1);
                                            string toReplace = text.Substring(i, lengthAll);
                                            output = text.Replace(toReplace, "[" + ourSiteForum + "]" + "(" + http + ")");
                                            text = output;
                                            i = i + +1 + ourSiteForum.Length + 1 + 1 + http.Length + 1 + -1;
                                            goto GetMeOutOfHere;
                                        }
                                    }
                                }

                            }
                        }
                    }
                }

            }
        }
        Console.WriteLine(output);
    }
}

//<p><a href="http://academy.telerik.com">our site</a>. Also <a href="www.devbg.org">our forum</a>.</p>



//using System;
//using System.Text.RegularExpressions;

//class Program
//{



//    private static string ReplaceAnchorTags(string input)
//    {
//        string anchorPattern = @"<\s*a\s[^>]*?\bhref\s*=\s*" + @"('(?<url>[^']*)'|""(?<url>[^""]*)""|" + @"(?<url>\S*))[^>]*>" + @"(?<linktext>[^<]*)<\s*/a\s*>";
//        string result = Regex.Replace(input, anchorPattern, delegate (Match m) { return String.Format("[URL={0}]{1}[/URL]", m.Groups["url"].Value, m.Groups["linktext"].Value); });
//        return result;
//    }
//    static void Main()
//    {
//        string html = Console.ReadLine();

//        string outputHtml = ReplaceAnchorTags(html);

//        Console.WriteLine(outputHtml);
//    }
//}