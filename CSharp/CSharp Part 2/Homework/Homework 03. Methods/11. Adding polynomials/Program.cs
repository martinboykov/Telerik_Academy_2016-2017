using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program
    {
        static int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
        static int[] numberA = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
        static int[] numberB = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
        static int aboveTen = 0;
        static int currentSum = 0;
        static void Main(string[] args)
        {
            if (numberB.Length < numberA.Length)
            {
                CalculateSumAB();
            }
            else 
            {
                CalculateSumBA();
            }
        }
        static void CalculateSumAB()
        {
            var result = new StringBuilder();
            for (int i = 0; i < numberB.Length; i++)
            {
                currentSum = (numberA[i] + numberB[i]) + aboveTen;
                result.Append(currentSum);
                result.Append(" ");
                
            }
            for (int i = numberB.Length; i < numberA.Length; i++)
            {
                currentSum = numberA[i];
            }
            
            Console.WriteLine(result);
        }
        static void CalculateSumBA()
        {
            var result = new StringBuilder();
            for (int i = 0; i < numberA.Length; i++)
            {
                currentSum = (numberA[i] + numberB[i]) + aboveTen;
                result.Append(currentSum);
                result.Append(" ");
            }
            for (int i = numberA.Length; i < numberB.Length; i++)
            {
                currentSum = numberB[i];
                result.Append(currentSum);
                result.Append(" ");
            }
            Console.WriteLine(result);
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _11.Adding_polynomials
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
//            int[] numberA = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
//            int[] numberB = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
//            if (numberB.Length < numberA.Length)
//            {
//                CalculateSumAB(numberA, numberB);
//            }
//            else if (numberB.Length > numberA.Length)
//            {
//                CalculateSumBA(numberA, numberB);
//            }
//            else
//            {
//                CalculateSumAA(numberA, numberB);
//            }

//        }
//        public static void CalculateSumAB(int[] numberA, int[] numberB)
//        {
//            int aboveTen = 0;
//            int currentSum = 0;
//            var result = new StringBuilder();
//            for (int i = 0; i < numberB.Length; i++)
//            {
//                currentSum = ((numberA[i] + numberB[i]) % 10) + aboveTen;
//                result.Append(currentSum);
//                result.Append(" ");

//            }
//            for (int i = numberB.Length; i < numberA.Length; i++)
//            {
//                currentSum = (numberA[i]);
//            }

//            Console.WriteLine(result);
//        }
//        public static void CalculateSumBA(int[] numberA, int[] numberB)
//        {
//            int aboveTen = 0;
//            int currentSum = 0;
//            var result = new StringBuilder();

//            for (int i = 0; i < numberA.Length; i++)
//            {
//                currentSum = ((numberA[i] + numberB[i])) + aboveTen;
//                result.Append(currentSum);
//                result.Append(" ");

//            }
//            for (int i = numberA.Length; i < numberB.Length; i++)
//            {
//                currentSum = (numberB[i]);
//                result.Append(currentSum);
//                result.Append(" ");
//            }

//            Console.WriteLine(result);
//        }
//        public static void CalculateSumAA(int[] numberA, int[] numberB)
//        {
//            int aboveTen = 0;
//            int currentSum = 0;
//            var result = new StringBuilder();
//            for (int i = 0; i < numberA.Length; i++)
//            {
//                currentSum = ((numberA[i] + numberB[i])) + aboveTen;
//                result.Append(currentSum);
//                result.Append(" ");

//            }

//            Console.WriteLine(result);

//        }
//    }
//}