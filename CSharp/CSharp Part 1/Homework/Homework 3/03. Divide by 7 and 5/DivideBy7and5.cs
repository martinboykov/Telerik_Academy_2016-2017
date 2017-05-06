using System;

class DivideBy7and5
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}