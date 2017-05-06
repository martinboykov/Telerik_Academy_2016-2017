using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => decimal.Parse(y)).ToList();
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine("{0:F2}",numbers.Average());
            Console.WriteLine(numbers.Sum());
            decimal product = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);
        }
    }
}
