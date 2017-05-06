using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            for (int i = 0; i < N; i++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }
            intList.Sort();
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
