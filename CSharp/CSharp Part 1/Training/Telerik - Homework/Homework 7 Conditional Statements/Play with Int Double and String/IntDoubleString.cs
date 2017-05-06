//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.
//Print the result at the console. Use switch statement.

//Example 1:
//program user
//Please choose a           type:	
//1 --> int
//2 --> double
//3 --> string              3
//Please enter a string:	hello
//hello*	

//Example 2:
//program                   user
//Please choose a type:	
//1 --> int
//2 --> double              2
//3 --> string
//Please enter a double:	1.5
//2.5

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class IntDoubleString
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        while (true)
        {
            string terminate;
            try
            {
                string one = "1";
                string two = "2";
                string three = "3";
                int variableInt = 0;
                double variableDouble = 0;
                string variableString = null;
                string chooseType = null;
                Console.Write("Please choose a type: ");
                chooseType = Console.ReadLine();
                if (chooseType == one)
                {
                    Console.Write("Please enter a integer: ");
                    variableInt = Int32.Parse(Console.ReadLine());
                    Console.Write("The result is:");
                    Console.WriteLine(variableInt);
                }
                else if (chooseType == two)
                {
                    Console.Write("Please enter a double: ");
                    variableDouble = double.Parse(Console.ReadLine());
                    Console.Write("The result is: ");
                    Console.WriteLine(variableDouble);
                }
                else if (chooseType == three)
                {
                    Console.Write("Please enter a string: ");
                    variableString = Console.ReadLine();
                    Console.Write("You entered: ");
                    Console.WriteLine(variableString);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong entering!\nPress 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                    Console.WriteLine();
                    terminate = Console.ReadLine();
                    if (terminate == "exit")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                Console.WriteLine();
                terminate = Console.ReadLine();
                if (terminate == "exit")
                {
                    Environment.Exit(0);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
            Console.WriteLine();
            terminate = Console.ReadLine();
            if (terminate == "exit")
            {
                Environment.Exit(0);
            }
        }
    }
}