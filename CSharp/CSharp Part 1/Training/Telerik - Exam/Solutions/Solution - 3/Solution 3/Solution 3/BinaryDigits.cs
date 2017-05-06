using System;

class BinaryDigits
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        string Nbits = Convert.ToString(N, 2);
        char[] bits = Nbits.ToCharArray();
        char[] last16 = new char[16];
        for (int i = 0; i < last16.Length; i++)
        {
            if ((i > bits.Length || (i == bits.Length)))
            {
                last16[last16.Length - 1 - i] = '0';
            }
            else
            {
                switch (i + 1)
                {
                    case 1: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 2: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 3: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 4: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 5: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 6: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 7: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 8: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 9: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 10: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 11: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 12: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 13: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 14: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 15: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                    case 16: last16[last16.Length - 1 - i] = bits[bits.Length - 1 - i]; break;
                }
            }
        }
        char[,] bitOne = new char[5, 3] { { '.', '#', '.' }, { '#', '#', '.' }, { '.', '#', '.' }, { '.', '#', '.' }, { '#', '#', '#' } };

        char[,] bitZero = new char[5, 3] { { '#', '#', '#' }, { '#', '.', '#' }, { '#', '.', '#' }, { '#', '.', '#' }, { '#', '#', '#' } };
        for (int i = 0; i < last16.Length; i++)
        {
            if (last16[i] == '0')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitZero[0, j]));
                }
            }
            else if (last16[i] == '1')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitOne[0, j]));
                }
            }
            if (i < (last16.Length - 1))
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        for (int i = 0; i < last16.Length; i++)
        {
            if (last16[i] == '0')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitZero[1, j]));
                }
            }
            else if (last16[i] == '1')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitOne[1, j]));
                }
            }
            if (i < (last16.Length - 1))
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        for (int i = 0; i < last16.Length; i++)
        {
            if (last16[i] == '0')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitZero[2, j]));
                }
            }
            else if (last16[i] == '1')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitOne[2, j]));
                }
            }
            if (i < (last16.Length - 1))
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        for (int i = 0; i < last16.Length; i++)
        {
            if (last16[i] == '0')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitZero[3, j]));
                }
            }
            else if (last16[i] == '1')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitOne[3, j]));
                }
            }
            if (i < (last16.Length - 1))
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
        for (int i = 0; i < last16.Length; i++)
        {
            if (last16[i] == '0')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitZero[4, j]));
                }
            }
            else if (last16[i] == '1')
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0}", bitOne[4, j]));
                }
            }
            if (i < (last16.Length - 1))
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
}

//По-елегантно решение с извършване на побитови операции.

//using System;

//internal class BinaryDigits
//{
//    private static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        for (int row = 0; row < 5; row++)
//        {
//            for (int bit = 15; bit >= 0; bit--)
//            {
//                bool isOne = ((1 << bit) & N) > 0;
//                if (isOne)
//                {
//                    // The current bit is one
//                    switch (row)
//                    {
//                        case 0:
//                        case 2:
//                        case 3:
//                            Console.Write(".#.");
//                            break;
//                        case 1:
//                            Console.Write("##.");
//                            break;
//                        case 4:
//                            Console.Write("###");
//                            break;
//                    }
//                }
//                else
//                {
//                    switch (row)
//                    {
//                        case 0:
//                        case 4:
//                            Console.Write("###");
//                            break;
//                        case 1:
//                        case 2:
//                        case 3:
//                            Console.Write("#.#");
//                            break;
//                    }
//                }
//                if (bit > 0)
//                {
//                    Console.Write(".");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}
