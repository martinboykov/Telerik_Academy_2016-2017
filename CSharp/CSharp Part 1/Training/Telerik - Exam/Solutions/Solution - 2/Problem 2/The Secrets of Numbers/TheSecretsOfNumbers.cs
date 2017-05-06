using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Numerics;

class TheSecretsOfNumbers
{
    static void Main()
    {
        var N = BigInteger.Parse(Console.ReadLine());
        if (N < 0)
        {
            N = N * (-1);
        }
        BigInteger numberTemp = N;
        long numberLength = 1;
        while ((numberTemp /= 10) >= 1)
        {
            numberLength++;
        }
        BigInteger specialSumOdd = 0;
        BigInteger specialSumEven = 0;
        BigInteger numberOdd = N;
        BigInteger numberEven = N;
        if (numberLength % 2 == 0)
        {
            for (int i = 1; i < numberLength; i = i + 2)
            {
                specialSumOdd = specialSumOdd + (numberOdd % 10) * i * i;
                numberOdd = numberOdd / 100;
            }
            numberEven = numberEven / 10;
            for (int i = 2; i < numberLength + 1; i = i + 2)
            {
                specialSumEven = specialSumEven + (numberEven % 10) * (numberEven % 10) * i;
                numberEven = numberEven / 100;
            }
        }
        else if (numberLength % 2 != 0)
        {
            for (int i = 1; i < numberLength + 1; i = i + 2)
            {
                specialSumOdd = specialSumOdd + (numberOdd % 10) * i * i;
                numberOdd = numberOdd / 100;
            }
            numberEven = numberEven / 10;
            for (int i = 2; i < numberLength + 1; i = i + 2)
            {
                specialSumEven = specialSumEven + (numberEven % 10) * (numberEven % 10) * i;
                numberEven = numberEven / 100;
            }
        }
        BigInteger specialSumBig = specialSumOdd + specialSumEven;
        long specialSum = (long)specialSumBig;
        long R = specialSum % 26;
        long specialSequenceLength = specialSum % 10;
        long letterPosition = R + 1;
        if (specialSequenceLength != 0)
        {
            Console.WriteLine(specialSum);
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphaSequence = new char[specialSequenceLength];
            for (int i = 0; i < specialSequenceLength; i++)
            {
                while (letterPosition > 26)
                {
                    letterPosition = letterPosition - 26;
                }
                switch (letterPosition)
                {
                    case 1: alphaSequence[i] = alphabet[0]; break;
                    case 2: alphaSequence[i] = alphabet[1]; break;
                    case 3: alphaSequence[i] = alphabet[2]; break;
                    case 4: alphaSequence[i] = alphabet[3]; break;
                    case 5: alphaSequence[i] = alphabet[4]; break;
                    case 6: alphaSequence[i] = alphabet[5]; break;
                    case 7: alphaSequence[i] = alphabet[6]; break;
                    case 8: alphaSequence[i] = alphabet[7]; break;
                    case 9: alphaSequence[i] = alphabet[8]; break;
                    case 10: alphaSequence[i] = alphabet[9]; break;
                    case 11: alphaSequence[i] = alphabet[10]; break;
                    case 12: alphaSequence[i] = alphabet[11]; break;
                    case 13: alphaSequence[i] = alphabet[12]; break;
                    case 14: alphaSequence[i] = alphabet[13]; break;
                    case 15: alphaSequence[i] = alphabet[14]; break;
                    case 16: alphaSequence[i] = alphabet[15]; break;
                    case 17: alphaSequence[i] = alphabet[16]; break;
                    case 18: alphaSequence[i] = alphabet[17]; break;
                    case 19: alphaSequence[i] = alphabet[18]; break;
                    case 20: alphaSequence[i] = alphabet[19]; break;
                    case 21: alphaSequence[i] = alphabet[20]; break;
                    case 22: alphaSequence[i] = alphabet[21]; break;
                    case 23: alphaSequence[i] = alphabet[22]; break;
                    case 24: alphaSequence[i] = alphabet[23]; break;
                    case 25: alphaSequence[i] = alphabet[24]; break;
                    case 26: alphaSequence[i] = alphabet[25]; break;
                }
                letterPosition = letterPosition + 1;
            }
            for (int i = 0; i < specialSequenceLength; i++)
            {
                Console.Write(alphaSequence[i]);
            }
        }
        else if (specialSequenceLength == 0)
        {
            Console.WriteLine(specialSum);
            Console.WriteLine("{0} has no secret alpha-sequence", N);
        }

    }
}