using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        //input N and M
        string inputFormat = Console.ReadLine();
        string[] format = inputFormat.Split(' ');
        int lettersPerLine = int.Parse(format[0]);
        int lettersPerSubsequence = int.Parse(format[1]);

        //input Encodet Genome
        string encodedGenome = Console.ReadLine();

        //Decode Genome
        StringBuilder decodedGenome = DecodeGenome(encodedGenome);

        //Print Decoded Genome
        PrintFormattedOutput(decodedGenome, lettersPerLine, lettersPerSubsequence);
    }

    private static void PrintFormattedOutput(StringBuilder decodedGenome, int lettersPerLine, int lettersPerSubsequence)
    {
        int outputLines = (int)Math.Ceiling((double)decodedGenome.Length / (double)lettersPerLine);
        int maxLineNumberDidgits = outputLines.ToString().Length;
        StringBuilder currentFormattedLine = new StringBuilder();
        int currentIndexOfDecodedGenome = 0;
        for (int line = 1; line <= outputLines; line++)
        {
            string leadingOntervals = new string(' ', maxLineNumberDidgits - line.ToString().Length);
            currentFormattedLine.Append(leadingOntervals);
            currentFormattedLine.Append(line);
            currentIndexOfDecodedGenome = (line - 1) * lettersPerLine;//???? +1
            for (int i = currentIndexOfDecodedGenome; i < line*lettersPerLine; i++)
            {
                if (Math.Abs(currentIndexOfDecodedGenome - i) % lettersPerSubsequence == 0) 
                {
                    currentFormattedLine.Append(' ');
                }
                if (i >= decodedGenome.Length)
                {
                    break;
                }
                currentFormattedLine.Append(decodedGenome[i]);
                
            }
            Console.WriteLine(currentFormattedLine);
            currentFormattedLine.Clear();
        }
        
    }

    private static StringBuilder DecodeGenome(string encodedGenome)
    {
        StringBuilder decodedGenome = new StringBuilder();
        StringBuilder repeatTimesString = new StringBuilder();
        foreach (char symbol in encodedGenome)
        {
            if (symbol == 'A' || symbol == 'G' || symbol == 'C' || symbol == 'T')
            {
                int repeatTimes = 1;
                if (repeatTimesString.Length != 0)
                {
                    repeatTimes = int.Parse(repeatTimesString.ToString());
                    repeatTimesString.Clear();
                }
                string genomeSubsequence = new string(symbol, repeatTimes);
                decodedGenome.Append(genomeSubsequence);

            }
            else
            {
                repeatTimesString.Append(symbol);
            }
        }
        return decodedGenome;
    }
}