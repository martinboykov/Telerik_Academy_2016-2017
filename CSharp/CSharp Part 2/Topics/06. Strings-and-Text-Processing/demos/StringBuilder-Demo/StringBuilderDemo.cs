using System;
using System.Text;

class StringBuilderDemo
{
    public static string ReverseItA(string s)
    {
        DateTime startTime = DateTime.Now;
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
        DateTime endTime = DateTime.Now;
        Console.WriteLine("... done in {0} seconds", endTime - startTime);
    }

    public static string ReverseItB(string s)
    {
        DateTime startTime = DateTime.Now;
        StringBuilder sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
        DateTime endTime = DateTime.Now;
        Console.WriteLine("... done in {0} seconds", endTime - startTime);
    }

    public static string ExtractCapitals(string s)
    {
        DateTime startTime = DateTime.Now;
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (Char.IsUpper(ch))
            {
                result.Append(ch);
            }
        }
        return result.ToString();
    }

    public static string DupCharA(char ch, int count)
    {
        DateTime startTime = DateTime.Now;
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            result.Append(ch);
        }
        DateTime endTime = DateTime.Now;
        Console.WriteLine("... done in {0} seconds", endTime - startTime);
        return result.ToString();
        
    }

    public static string DupCharB(char ch, int count)
    {
        DateTime startTime = DateTime.Now;
        StringBuilder result = new StringBuilder(count);
        for (int i = 0; i < count; i++)
        {
            result.Append(ch);
        }
        DateTime endTime = DateTime.Now;
        Console.WriteLine("... done in {0} seconds", endTime - startTime);
        return result.ToString();
        
    }

    static void Main()
    {
        string s = "Telerik Academy";

        string reversedA = ReverseItA(s);
        Console.WriteLine(reversedA);
        string reversedB = ReverseItB(s);
        Console.WriteLine(reversedB);


        string capitals = ExtractCapitals(s);
        Console.WriteLine(capitals);


        DupCharA('a', 200000000);
        DupCharB('a', 200000000);
    }
}
