//Problem 8. Digit as Word

//Write a program that asks for a digit(0-9), and depending on the input, shows the digit as a word(in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.
//Examples:

// d        result
// 2    	two
// 1    	one
// 0    	zero
// 5    	five
//-0.1	    not a digit
// hi       not a digit
// 9	    nine
// 10	    not a digit

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class DigitWord
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
                Console.Write("n = ");
                string n = Console.ReadLine();
                double integer;
                bool check = double.TryParse(n, out integer);
                bool a = string.IsNullOrWhiteSpace(n);
                if (a == true)
                {
                    Console.WriteLine("Try aggain!");
                    Console.WriteLine();
                    Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                    Console.WriteLine();
                    terminate = Console.ReadLine();
                    if (terminate == "exit")
                    {
                        Environment.Exit(0);
                    }
                }
                else if (check == false)
                {
                    Console.WriteLine("not a digit");
                    Console.WriteLine();
                    Console.WriteLine("Press 'enter' to try aggain or type 'exit' in the console to exit from the program!");
                    Console.WriteLine();
                    terminate = Console.ReadLine();
                    if (terminate == "exit")
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    double value = double.Parse(n);
                    bool isInt = value % 1 == 0;
                    if (value < 0)
                    {
                        Console.WriteLine("not a digit");
                    }
                    else if (isInt == false)
                    {
                        Console.WriteLine("not a digit");
                    }
                    else if (value == 0)
                    {
                        Console.WriteLine("zero");
                    }
                    else if (value == 1)
                    {
                        Console.WriteLine("one");
                    }
                    else if (value == 2)
                    {
                        Console.WriteLine("two");
                    }
                    else if (value == 3)
                    {
                        Console.WriteLine("three");
                    }
                    else if (value == 4)
                    {
                        Console.WriteLine("four");
                    }
                    else if (value == 5)
                    {
                        Console.WriteLine("five");
                    }
                    else if (value == 6)
                    {
                        Console.WriteLine("six");
                    }
                    else if (value == 7)
                    {
                        Console.WriteLine("seven");
                    }
                    else if (value == 8)
                    {
                        Console.WriteLine("eight");
                    }
                    else if (value == 9)
                    {
                        Console.WriteLine("eight");
                    }
                    else if (value > 9)
                    {
                        Console.WriteLine("not a digit");
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
        }
    }
}