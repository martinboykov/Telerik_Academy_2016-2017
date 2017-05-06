using System;

class SplittingStrings
{
    static void Main()
    {
        //with arrays /vectors/
        string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
        string[] beers = listOfBeers.Split(' ', ',', '.');
        //string[] beers = listOfBeers.Split(
        //    new char[] {' ', ',', '.'}, 
        //    StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Available beers are:");
        foreach (string beer in beers)
        {
            // Two sequential separators in the input cause
            // presence of empty element in the result
            if (beer != "")
            {
                Console.WriteLine(beer);
            }
        }


        //with matrices
        string matrix =
            "1 5 -3 6" + "\n" +
            "2 22 3 16";
        //Console.WriteLine(matrix);
        string[] rows = matrix.Split('\n');
        int[,] m = new int[2, 4];
        for (int row = 0; row < 2; row++)
        {
            string[] values = rows[row].Split(' ');
            for (int col = 0; col < 4; col++)
            {
                //create matrix
                m[row, col] = int.Parse(values[col]);
            }
        }
        //Print values of the matrix
        for (int row = 0; row < m.GetLength(0); row++)
        {
            for (int col = 0; col < m.GetLength(1); col++)
            {
                Console.WriteLine(m[row, col]);
            }
        }










    }
}
