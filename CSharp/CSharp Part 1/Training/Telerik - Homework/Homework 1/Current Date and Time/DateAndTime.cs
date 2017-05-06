//Problem 14.* Current Date and Time

//Create a console application that prints the current date and time.Find out how in Internet.

using System;
class DateAndTime
{
    static void Main()
    {
        //DateTime.Now gives Date and Time in the moment based on the Date and Time of the local Computer.
        DateTime Now = DateTime.Now;
        Console.WriteLine(Now);
    }
}