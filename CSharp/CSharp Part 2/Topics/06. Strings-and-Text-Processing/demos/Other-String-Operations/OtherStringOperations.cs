using System;

class OtherStringOperations
{
    static void Main()
    {
        //ALLWAYS CREATES NEW STRING

        //1 String.Replace() example
        Console.WriteLine(1);
        string cocktail = "Vodka + Martini + Cherry";
        string replaced = cocktail.Replace("+", "and");
        Console.WriteLine(replaced);
        Console.WriteLine();

        //2 String.Remove() example
        Console.WriteLine(2);
        string price = "$ 1234567"; 
        string lowPrice = price.Remove(2, 3); //(Index of: price[2], remove 3 chars)
        Console.WriteLine(lowPrice);
        Console.WriteLine();

        //3 Uppercase and lowercase conversion examples
        Console.WriteLine(3);
        string alpha = "aBcDeFg";
        string lowerAlpha = alpha.ToLower();
        Console.WriteLine(lowerAlpha);
        string upperAlpha = alpha.ToUpper();
        Console.WriteLine(upperAlpha);
        Console.WriteLine();


        //4 Trim() example
        Console.WriteLine(4);
        string s = "  example of white space ";
        string clean = s.Trim();
        Console.WriteLine(clean);
        Console.WriteLine();

        //5 Trim(chars) example
        Console.WriteLine(5);
        s = " \t\nHello!!! \n";
        clean = s.Trim(' ', ',', '!', '\n', '\t');
        Console.WriteLine(clean);
        Console.WriteLine();

        //6 TrimStart() example
        Console.WriteLine(6);
        s = "   C#   ";
        clean = s.TrimStart();
        Console.WriteLine(clean);
        Console.WriteLine();

        //7 TrimEnd() example
        Console.WriteLine(7);
        s = "   C#   ";
        clean = s.TrimEnd();
        Console.WriteLine(clean);
    }
}