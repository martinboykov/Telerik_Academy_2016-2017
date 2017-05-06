//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it.Try to compile the code.


using System;

class DeclareVariables
{
    static void Main()
    {
        sbyte numberOne = 97;
        sbyte numberTwo = -115;
        short numberThree = -10000;
        ushort numberFour = 52130;
        int numberFive = 4825932;
        Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4}", numberOne, numberTwo, numberThree, numberFour, numberFive);

        //Console print:
        //97
        //-115
        //-10000
        //52130
        //4825932
    }
}