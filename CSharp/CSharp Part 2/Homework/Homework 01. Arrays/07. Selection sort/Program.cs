using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {   // with  Selection sort algorithm
            int N = int.Parse(Console.ReadLine());
            int[] intArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            int tmp, min_key;
            for (int j = 0; j < intArray.Length - 1; j++)
            {
                min_key = j;//sets the position at index 'j'

                for (int k = j + 1; k < intArray.Length; k++)
                {
                    if (intArray[k] < intArray[min_key])
                    {
                        min_key = k; //when/if it finds smaller number sets the position at index 'k' of the smaller number
                    }
                }
                tmp = intArray[min_key];
                intArray[min_key] = intArray[j];//swap positions
                intArray[j] = tmp;//swap positions
            }

            //Console.WriteLine("The Array After Selection Sort is: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}

//with list and Sort()
//int N = int.Parse(Console.ReadLine());
//List<int> intList = new List<int>();
//for (int i = 0; i<N; i++)
//{
//    intList.Add(int.Parse(Console.ReadLine()));
//}
//intList.Sort();
//foreach (var item in intList)
//{
//    Console.WriteLine(item);
//}

