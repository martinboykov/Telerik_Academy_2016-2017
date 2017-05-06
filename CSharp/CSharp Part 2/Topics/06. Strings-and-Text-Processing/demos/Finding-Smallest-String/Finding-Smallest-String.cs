using System;

class ReadingPrintingStrings
{
    static void Main()
    {
        string[] towns = {"BB", "B", "Plovdiv",
			"Pleven", "Bourgas", "Rousse", "Stara Zagora",
			"Veliko Tarnovo", "Yambol", "Sliven"};
        string firstTown = towns[0];
        
        //StringComparer
        Console.WriteLine(String.Compare(towns[0], towns[1], true));
        Console.WriteLine(towns[0].CompareTo(towns[1]));



        //Equals
        Console.WriteLine(towns[0].Equals(towns[1]));


        //for (int i = 1; i < towns.Length; i++)
        //{
        //    string currentTown = towns[i];
        //    if (String.Compare(currentTown, firstTown,false) < 0)
        //    {
        //        firstTown = currentTown;
        //    }
        //}
        //Console.WriteLine("First town: {0}", firstTown);
    }
}
