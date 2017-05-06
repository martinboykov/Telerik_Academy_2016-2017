using System;
using System.Globalization;
using System.Threading;

class IntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string variable = Console.ReadLine();
        string value = Console.ReadLine();
        switch (variable)
        {
            case "integer":
                int valueInt = Convert.ToInt32(value);
                Console.WriteLine("{0}", valueInt + 1);
                break;
            case "real":
                double valueDouble = Convert.ToDouble(value);
                Console.WriteLine("{0:F2}", valueDouble + 1);
                break;
            case "text":
                Console.WriteLine("{0}*", value);
                break;
        }
    }
}