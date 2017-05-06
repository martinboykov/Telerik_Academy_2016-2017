using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            List<int> currentList = new List<int>();
            List<int> maxList = new List<int>();

            int maxI = (int)Math.Pow(2, numbers.Length) - 1;
            for (int i = 1; i <= maxI; i++)
            {
                List<int> sublist = new List<int>();
                for (int j = 0; j < numbers.Length; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        currentList.Add(numbers[j]);
                    }
                }
                if (isSorted(currentList))
                {
                    if (currentList.Count > maxList.Count)
                    {
                        maxList.Clear();
                        for (int j = 0; j < currentList.Count; j++)
                        {
                            maxList.Add(currentList[j]);
                        }
                    }
                    currentList.Clear();
                }
                else
                {
                    currentList.Clear();
                }
            }
            //Console.WriteLine();

            //foreach (var value in maxList)
            //{
            //    Console.Write(value);
            //    Console.Write(' ');
            //}
            //Console.WriteLine();
            Console.WriteLine(N - maxList.Count);
        }
        static bool isSorted(List<int> currentList)
        {
            for (int i = 0; i < currentList.Count - 1; i++)
            {
                if (currentList[i + 1] >= currentList[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
//int N = int.Parse(Console.ReadLine());
//List<int> list = new List<int>();
//List<int> LIS = new List<int>();

//            for (int i = 0; i<N; i++)
//            {
//                list.Add(int.Parse(Console.ReadLine()));
//            }
//            LIS.Add(list[0]);
//            bool bigger = true;
//int equalCount = 0;
//int equalIndex = 0;
//            for (int i = 1; i<list.Count; i++)
//            {
//                for (int j = 0; j<LIS.Count; j++)
//                {
//                    if (list[i] < LIS[j])
//                    {
//                        LIS[j] = list[i]; bigger = false;  break;
//                    }
//                    else if (list[i] == LIS[j])
//                    {
//                        bigger = false;
//                    }
//                }
//                if (bigger)
//                {
//                    LIS.Add(list[i]);
//                }
//                //if (equalCount>0)
//                //{
//                //    for (int equal = 0; equal < equalCount; equal++)
//                //    {
//                //        LIS.Insert(equalIndex, list[i]);
//                //    }
//                //}
//                equalIndex = 0;
//                bigger = true;
//            }
//            Console.WriteLine();
//            Console.WriteLine(list.Count - LIS.Count);
//            Console.WriteLine();
//            foreach (var item in LIS)
//            {
//                Console.WriteLine(item);
//            }