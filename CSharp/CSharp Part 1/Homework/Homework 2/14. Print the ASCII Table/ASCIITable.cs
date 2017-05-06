using System;

namespace PrintASCII
{
    class PrintASCII
    {

        static void Main(string[] args)
        {
            for (char c = (char)33; c <= (char)126; ++c)
            {
                Console.Write(c);
            }
        }
    }
}