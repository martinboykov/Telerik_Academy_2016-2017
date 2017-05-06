using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            const int NumberBits = 32;
            int SearchBits = 0;
            int search = int.Parse(Console.ReadLine()); //search = P
            int searchTemp = search;
            while (searchTemp > 0)
            {
                searchTemp >>= 1;
                SearchBits++;
            }
            string searchAsString = Convert.ToString(search, 2).PadLeft(SearchBits, '0'); // for debugging only
            int n = int.Parse(Console.ReadLine());// n = M (number of lines)
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());//number = N
                string numberAsString = Convert.ToString(number, 2).PadLeft(NumberBits, '0'); // for debugging only


                for (int startFromBit = 0; startFromBit < NumberBits; startFromBit++)
                {
                    bool found = true;
                    for (int searchBit = 0; searchBit < SearchBits; searchBit++)
                    {
                        int numberBit = startFromBit + searchBit;//which of the bits will check
                        int numberMask = 1 << numberBit;//create mask for this bit
                        int numberAndMask = number & numberMask;// apply the mask to find if 1 or 0
                        int numberBitValue = numberAndMask >> numberBit;//returns 1 or 0

                        int searchMask = 1 << searchBit;//create a mask for P
                        int searchAndMask = search & searchMask;//apply mask to search sequence (P)
                        int searchBitValue = searchAndMask >> searchBit;//returns 1 or 0

                        if (numberBitValue != searchBitValue)
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        count++;
                        for (int searchBit = 0; searchBit < SearchBits; searchBit++)
                        {
                            int numberBit = startFromBit + searchBit;//which of the bits will check
                            int numberMask = 1 << numberBit;//create mask for this bit
                             number = number & ~(numberMask);// apply the mask to swich to 0
                            //int numberBitValue = numberAndMask >> numberBit;//returns 1 or 0

                            //int searchMask = 1 << searchBit;//create a mask for P
                            //int searchAndMask = search & searchMask;//apply mask to search sequence (P)
                            //int searchBitValue = searchAndMask >> searchBit;//returns 1 or 0
                        }

                    }
                }

                Console.WriteLine(number);
            }

        }
    }
}
//int n = int.Parse(Console.ReadLine());