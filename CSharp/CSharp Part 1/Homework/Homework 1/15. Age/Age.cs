//CSharp-Part-1/Topics/01. Introduction-to-Programming/homework/15. Age/
//Description
//Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints on the console how old you are you now and how old will you be after 10 years.

//Input
//The input will always consist of a single line - a birthdate.

//Output
//You should print two lines with one number on the each line:
//How old are you now, on the first line.
//How old will you be after 10 years, on the second line.

//Constraints
//The date read from the console will always be in a valid DateTime format.
//All dates will be earlier than 2017.
//Time limit: 0.1s
//Memory limit: 16MB

using System;
using System.Globalization;
using System.Threading;

class Age
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        int age = today.Year - birthDay.Year;
        if (birthDay > today.AddYears(-age))
        {
            age--;
        }
        Console.WriteLine(age);

        DateTime inTenYears = today.AddYears(10);
        int ageInTenYears = inTenYears.Year - birthDay.Year;
        if (birthDay > inTenYears.AddYears(-ageInTenYears))
        {
            ageInTenYears--;
        }
        Console.WriteLine(ageInTenYears);

    }
}