//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:

//n         Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true

using System;

class ThirdDigit7
{
    static void Main()
    {
        string intCheck = Math.Abs(5).ToString();
        int maxValue = (intCheck.Length);
        Console.WriteLine(maxValue >= 3 ? intCheck[maxValue - 3] == '7' : maxValue > 3); //First checks if the lenght of the integer is bigger or equal to 3 signs, if True checks if third digit is 7 and if False returns False;

        intCheck = Math.Abs(701).ToString();
        maxValue = (intCheck.Length);
        Console.WriteLine(maxValue >= 3 ? intCheck[maxValue - 3] == '7' : maxValue > 3);

        intCheck = Math.Abs(9703).ToString();
        maxValue = (intCheck.Length);
        Console.WriteLine(maxValue >= 3 ? intCheck[maxValue - 3] == '7' : maxValue > 3);

        intCheck = Math.Abs(877).ToString();
        maxValue = (intCheck.Length);
        Console.WriteLine(maxValue >= 3 ? intCheck[maxValue - 3] == '7' : maxValue > 3);

        intCheck = Math.Abs(777877).ToString();
        maxValue = (intCheck.Length);
        Console.WriteLine(maxValue >= 3 ? intCheck[maxValue - 3] == '7' : maxValue > 3);

        intCheck = Math.Abs(9999799).ToString();
        maxValue = (intCheck.Length);
        Console.WriteLine(maxValue >= 3 ? intCheck[maxValue - 3] == '7' : maxValue > 3);

        //output:
        //false
        //true
        //true
        //false
        //false
        //true
    }
}