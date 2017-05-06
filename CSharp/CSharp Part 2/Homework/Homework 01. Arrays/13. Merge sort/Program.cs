using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Merge_sort
{
    class Program
    {

        static public void mergemethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }

        }
        static public void sortmethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                sortmethod(numbers, left, mid);
                sortmethod(numbers, (mid + 1), right);
                mergemethod(numbers, left, (mid + 1), right);

            }
        }
        static void Main(string[] args)

        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int len = numbers.Length;
            sortmethod(numbers, 0, len - 1);
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
        }
    }

}

//using Selection Sort Algorithm
//    -----------------------------
//int N = int.Parse(Console.ReadLine());
//List<int> intList = new List<int>();
//            for (int i = 0; i<N; i++)
//            {
//                intList.Add(int.Parse(Console.ReadLine()));
//            }
//            intList.Sort();
//            foreach (var item in intList)
//            {
//                Console.WriteLine(item);
//            }