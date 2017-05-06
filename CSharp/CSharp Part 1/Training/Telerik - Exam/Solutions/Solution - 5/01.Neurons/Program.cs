using System;
//using System.Threading;
//using System.Globalization;
//using System.Numerics;
//using System.IO;

class Program
{
    static void Main()
    {

        //StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
        //Console.SetIn(reader);

        for (int i = 0; i < 999999; i++)
        {
            string text = Console.ReadLine();
            if (text == "4294967295")
            {
                text = "0";
            }
            long? number;
            long dummy;
            if (long.TryParse(text, out dummy))
            {
                number = dummy;
                long n = (long)number;
                if (n != -1)
                {
                    string nBit = Convert.ToString(n, 2).PadLeft(32, '0');
                    long nTemp = n;

                    //for (int j = nBit.Length - 1; j >= 0; j--)//start loop to find ones
                    //{
                    //    if ((n & ((BigInteger)1 << j)) != 0)//if we find one =>
                    //    {

                    //        Console.Write(1);//=> type 1
                    //    }
                    //    else
                    //    {
                    //        Console.Write(".");
                    //    }
                    //}
                    //Console.WriteLine();
                    
                    
                    for (int j = nBit.Length - 1; j >= 0; j--)//start loop to find ones
                    {
                        
                        if ((n & ((long)1 << j)) > 0 && (n & ((long)1 << (j - 1))) == 0)
                        {
                            nTemp = nTemp & ~((long)1 << j); //change 1s to 0s
                            j = j - 1;
                            for (int k = j; k >= 0; k--)
                            {

                                while ((n & ((long)1 << k)) == 0) //till we reach 1 convert 0s to 1
                                {
                                    nTemp = nTemp | ((long)1 << k);
                                    k--;
                                }
                                while ((n & ((long)1 << k)) > 0) //then convert 1s to 0s
                                {
                                    nTemp = nTemp & ~((long)1 << k);
                                    k--;
                                }
                                j = k;
                                break;
                            }
                        }
                        if ((n & ((long)1 << j)) > 0 && (n & ((long)1 << (j - 1))) > 0 && (n & ((long)1 << (j - 2))) == 0)
                        {
                            nTemp = nTemp & ~((long)1 << j);
                            nTemp = nTemp & ~((long)1 << (j - 1));
                            j = j - 2;
                            for (int k = j; k >= 0; k--)
                            {

                                while ((n & ((long)1 << k)) == 0)
                                {
                                    nTemp = nTemp | ((long)1 << k);
                                    k--;
                                }
                                while ((n & ((long)1 << k)) > 0)
                                {
                                    nTemp = nTemp & ~((long)1 << k);
                                    k--;
                                }
                                j = k;
                                break;
                            }
                        }
                        if ((n & ((long)1 << j)) > 0 && (n & ((long)1 << (j - 1))) > 0 && (n & ((long)1 << (j - 2))) > 0 && (n & ((long)1 << (j - 3))) == 0)
                        {
                            nTemp = nTemp & ~((long)1 << j);
                            nTemp = nTemp & ~((long)1 << (j - 1));
                            nTemp = nTemp & ~((long)1 << (j - 2));
                            j = j - 3;
                            for (int k = j; k >= 0; k--)
                            {

                                while ((n & ((long)1 << k)) == 0)
                                {
                                    nTemp = nTemp | ((long)1 << k);
                                    k--;
                                }
                                while ((n & ((long)1 << k)) > 0)
                                {
                                    nTemp = nTemp & ~((long)1 << k);
                                    k--;
                                }
                                j = k;
                                break;
                            }
                        }
                        if ((n & ((long)1 << j)) > 0 && (n & ((long)1 << (j - 1))) > 0 && (n & ((long)1 << (j - 2))) > 0 && (n & ((long)1 << (j - 3))) > 0 && (n & ((long)1 << (j - 4))) == 0)
                        {
                            nTemp = nTemp & ~((long)1 << j);
                            nTemp = nTemp & ~((long)1 << (j - 1));
                            nTemp = nTemp & ~((long)1 << (j - 2));
                            nTemp = nTemp & ~((long)1 << (j - 3));
                            j = j - 4;
                            for (int k = j; k >= 0; k--)
                            {

                                while ((n & ((long)1 << k)) == 0)
                                {
                                    nTemp = nTemp | ((long)1 << k);
                                    k--;
                                }
                                while ((n & ((long)1 << k)) > 0)
                                {
                                    nTemp = nTemp & ~((long)1 << k);
                                    k--;
                                }
                                j = k;
                                break;
                            }
                        }
                        if ((n & ((long)1 << j)) > 0 && (n & ((long)1 << (j - 1))) > 0 && (n & ((long)1 << (j - 2))) > 0 && (n & ((long)1 << (j - 3))) > 0 && (n & ((long)1 << (j - 4))) > 0 && (n & ((long)1 << (j - 5))) == 0)
                        {
                            nTemp = nTemp & ~((long)1 << j);
                            nTemp = nTemp & ~((long)1 << (j - 1));
                            nTemp = nTemp & ~((long)1 << (j - 2));
                            nTemp = nTemp & ~((long)1 << (j - 3));
                            nTemp = nTemp & ~((long)1 << (j - 4));
                            j = j - 5;
                            for (int k = j; k >= 0; k--)
                            {

                                while ((n & ((long)1 << k)) == 0)
                                {
                                    nTemp = nTemp | ((long)1 << k);
                                    k--;
                                }
                                while ((n & ((long)1 << k)) > 0)
                                {
                                    nTemp = nTemp & ~((long)1 << k);
                                    k--;
                                }
                                j = k;
                                break;
                            }
                        }
                    }
                    if (nTemp > 0)
                    {
                        Console.WriteLine(nTemp);
                        //for (int j = nBit.Length - 1; j >= 0; j--)//start loop to find ones
                        //{
                        //    if ((nTemp & ((BigInteger)1 << j)) != 0)//if we find one =>
                        //    {

                        //        Console.Write(1);//=> type 1
                        //    }
                        //    else
                        //    {
                        //        Console.Write(".");
                        //    }
                        //}
                        //Console.WriteLine();

                    }
                    else
                    {
                        nTemp = 0;
                        Console.WriteLine(nTemp);

                        //for (int j = nBit.Length - 1; j >= 0; j--)//start loop to find ones
                        //{
                        //    if ((nTemp & ((BigInteger)1 << j)) != 0)//if we find one =>
                        //    {

                        //        Console.Write(1);//=> type 1
                        //    }
                        //    else
                        //    {
                        //        Console.Write(".");
                        //    }
                        //}
                        //Console.WriteLine();
                    }


                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }

        }
    }
}



//Optimised and simplistic soulution (fck ingenius)
//using System;

//class NeuronMapping
//{
//    static void Main()
//    {
//        const uint BIT = (uint)1;

//        while (true)
//        {
//            string input = Console.ReadLine();
//            if (input == "-1")
//            {
//                break;
//            }

//            uint thisRow = uint.Parse(input);

//            uint output = 0;

//            bool isInside = false;

//            int oneBitSequences = 0;

//            for (int ii = 0; ii < 32; ++ii)
//            {
//                uint mask = (BIT << ii);

//                if ((thisRow & mask) == 0)
//                {
//                    if (isInside)
//                        output |= mask;
//                    continue;
//                }
//                else
//                {
//                    oneBitSequences += 1;
//                    isInside = !isInside;
//                    while (ii < 32 && (thisRow & (BIT << ii)) != 0)
//                    {
//                        ii += 1;
//                    }
//                    // back off one step,
//                    // the for loop will increment the counter anyway
//                    ii -= 1;
//                }
//            }

//            if (oneBitSequences != 2)
//            {
//                output = 0;
//            }

//            Console.WriteLine(output);
//        }
//    }
//}
