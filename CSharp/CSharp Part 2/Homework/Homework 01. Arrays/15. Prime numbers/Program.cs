using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_numbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int maxPrime = 2;
            bool isPrime = true;
            for (int i = N; i > maxPrime; i--)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false; break;
                    }
                }
                if (isPrime)
                {
                    maxPrime = i;
                }
                isPrime = true;
            }
            Console.WriteLine(maxPrime);
        }
    }
}
//int n = int.Parse(Console.ReadLine());
//bool[] e = new bool[n + 1];//by default they're all false
//            for (int i = 2; i <= n; i++)
//            {
//                e[i] = true;//set all numbers to true
//            }
//            //weed out the non primes by finding mutiples 
//            for (int j = 2; j <= n; j++)
//            {
//                if (e[j])//is true
//                {
//                    for (long p = 2; (p* j) <= n; p++)
//                    {
//                        e[p * j] = false;
//                    }
//                }
//            }
//            for (int i = n; i > 0; i--)
//            {
//                if (e[i])
//                {
//                    Console.WriteLine(i); break;
//                }
//            }

//int N = int.Parse(Console.ReadLine());
//int maxPrime = 2;
//            if (N > 2)
//            {
//                maxPrime = 3;
//            }
//            if (N > 4)
//            {
//                maxPrime = 5;
//            }
//            if (N > 6)
//            {
//                maxPrime = 7;
//            }
//            bool isPrime = true;
//            for (int i = maxPrime + 1; i <= N; i++)
//            {
//                for (int j = 2; j <= Math.Sqrt(i); j++)
//                {
//                    if (i % j == 0)
//                    {
//                        isPrime = false; break;
//                    }
//                }
//                if (isPrime)
//                {
//                    maxPrime = i;
//                }
//                isPrime = true;
//            }
//            Console.WriteLine(maxPrime);


//int N = int.Parse(Console.ReadLine());
//List<int> integersList = new List<int>();
//            for (int i = 2; i <= N; i++)
//            {
//                integersList.Add(i);

//                for (int j = 0; j<integersList.Count-1; j++)
//                {
//                    if (integersList.Last() % integersList[j] == 0)
//                    {
//                        integersList.RemoveAt(integersList.Count - 1); break;
//                    }
//                }
//            }

//            Console.WriteLine(integersList.Max());



//bool[] notPrime = new bool[total];
//notPrime[0] = true;
//            notPrime[1] = true;
//            for (int i = 2; i <= Math.Sqrt(notPrime.Length); i++)
//            {
//                if (!notPrime[i])
//                {
//                    for (int j = i * 2; j<notPrime.Length; j += i)
//                    {
//                        notPrime[j] = true;
//                    }
//                }
//            }












//for (int index = 0; index<integersList.Count - 1; index++)
//            {
//                for (int i = index + 1; i<integersList.Count; i++)
//                {
//                    if (integersList[i] % integersList[index] == 0)
//                    {
//                        integersList.RemoveAt(i);
//                    }
//                }
//            }


//for (int j = integersList[0]; j <= Math.Sqrt(integersList.Last()); j++)
//{
//    if (integersList.Last() % j == 0)
//    {
//        integersList.RemoveAt(integersList.Count - 1);
//        break;
//    }
//}



//int N = int.Parse(Console.ReadLine());
//List<int> integersList = new List<int>();
//List<int> primeNumbersList = new List<int>();
//            for (int i = 1; i <= N; i++)
//            {
//                integersList.Add(i);
//            }
//            for (int i = 0; i<integersList.Count; i++)
//            {
//                if (integersList[i] != 0 && integersList[i] != 1)
//                {
//                    if (integersList[i] == 2)
//                    {
//                        primeNumbersList.Add(integersList[i]);
//                        continue;
//                    }
//                    else
//                    {
//                        bool isPrime = true;
//                        for (int j = 2; j <= Math.Sqrt(integersList[i]); j++)
//                        {
//                            if (integersList[i] % j == 0)
//                            {
//                                isPrime = false; break;
//                            }
//                        }
//                        if (isPrime)
//                        {
//                            primeNumbersList.Add(integersList[i]);
//                        }
//                    }
//                }
//            }
//            Console.WriteLine(primeNumbersList.Max());