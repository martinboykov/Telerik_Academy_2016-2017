using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int[] array2 = new int[N];
            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool isEqual = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i]!=array2[i])
                {
                    isEqual = false;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
