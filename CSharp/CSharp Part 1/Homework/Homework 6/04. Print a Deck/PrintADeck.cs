//Print a Deck

//Description
//Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

//Input
//On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.

//Output
//The output should follow the format bellow(assume our input is 5):  2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds

//Constraints
//The input character will always be a valid card sign.
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input   Output
//5	     2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//       3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//       ...
//       5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds

using System;
using System.Globalization;
using System.Threading;

class PrintADeck
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n;
        int k;
        char c;
        string inputString = Console.ReadLine();
        bool isInt = int.TryParse(inputString, out n);
        if (!isInt)
        {
            bool isChar = char.TryParse(inputString, out c);
            if (isChar)
            {
                n = c;
                switch (n)
                {
                    case 74:
                        n = 11;
                        break;
                    case 81:
                        n = 12;
                        break;
                    case 75:
                        n = 13;
                        break;
                    case 65:
                        n = 14;
                        break;
                }
            }
        }
        for (int i = 2; i <= n; i++)
        {
            if (i >= 2 && i <= 10)
            {
                Console.Write("{0} of spades, ", i);
                Console.Write("{0} of clubs, ", i);
                Console.Write("{0} of hearts, ", i);
                Console.Write("{0} of diamonds", i);
                Console.WriteLine();
            }
            else if (i > 10)
            {
                switch (i)
                {
                    case 11:
                        k = 74;
                        Console.Write("{0} of spades, ", (char)k);
                        Console.Write("{0} of clubs, ", (char)k);
                        Console.Write("{0} of hearts, ", (char)k);
                        Console.Write("{0} of diamonds", (char)k);
                        Console.WriteLine();
                        break;
                    case 12:
                        k = 81;
                        Console.Write("{0} of spades, ", (char)k);
                        Console.Write("{0} of clubs, ", (char)k);
                        Console.Write("{0} of hearts, ", (char)k);
                        Console.Write("{0} of diamonds", (char)k);
                        Console.WriteLine();
                        break;
                    case 13:
                        k = 75;
                        Console.Write("{0} of spades, ", (char)k);
                        Console.Write("{0} of clubs, ", (char)k);
                        Console.Write("{0} of hearts, ", (char)k);
                        Console.Write("{0} of diamonds", (char)k);
                        Console.WriteLine();
                        break;
                    case 14:
                        k = 65;
                        Console.Write("{0} of spades, ", (char)k);
                        Console.Write("{0} of clubs, ", (char)k);
                        Console.Write("{0} of hearts, ", (char)k);
                        Console.Write("{0} of diamonds", (char)k);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}