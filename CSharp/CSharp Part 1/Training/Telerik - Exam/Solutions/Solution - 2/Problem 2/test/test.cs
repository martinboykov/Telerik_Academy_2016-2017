using System;

class test
{
    static void Main()
    {
        long letterPosition = 23;
        long specialSequenceLength = 8;
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        for (int i = 0; i < 26; i++)
        {
            Console.Write(alphabet[i]);
           
        }
        char[] alphaSequence = new char[specialSequenceLength];
        for (int i = 0; i < 8; i++)
        {
            alphaSequence[i] = alphabet[i];
        }
        for (int i = 0; i < 8; i++)
        {
            Console.Write(alphaSequence[i]);

        }



    }
}