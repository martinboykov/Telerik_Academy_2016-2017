using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_array
{
    class Program
    {
        static int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
        static int[] numbersA = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
        static int[] numbersB = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToArray();
        static int[] minLength;
        static int[] maxLength;
        static int aboveTen = 0;
        static int currentSum = 0;
        static string output = null;
        static void Main(string[] args)
        {
            FindMaxArray();
            CalculateSum();
            PrintResult();
        }
        public static void FindMaxArray()
        {

            if (numbersA.Length > numbersB.Length)
            {
                minLength = numbersB;
                maxLength = numbersA;
            }
            else
            {
                minLength = numbersA;
                maxLength = numbersB;
            }
        }
        public static void CalculateSum()
        {
            var result = new StringBuilder();
            for (int i = 0; i < minLength.Length; i++)
            {
                currentSum = ((maxLength[i] + minLength[i] + aboveTen) % 10);
                result.Append(currentSum);
                result.Append(" ");
                if (((maxLength[i] + minLength[i] + aboveTen)) >= 10)
                {
                    aboveTen = 1;
                }
                else
                {
                    aboveTen = 0;
                }
            }
            for (int i = minLength.Length; i < maxLength.Length; i++)
            {
                currentSum = (maxLength[i] + aboveTen) % 10;
                result.Append(currentSum);
                result.Append(" ");
                if (((maxLength[i] + aboveTen)) >= 10)
                {
                    aboveTen = 1;
                }
                else
                {
                    aboveTen = 0;
                }
            }
            if (aboveTen == 1)
            {
                result.Append(1);
            }
            output = result.ToString();
        }
        public static void PrintResult()
        {
            Console.WriteLine(output);
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//class NumberAsArray
//{
//    static void Main()
//    {
//        Console.ReadLine();
//        byte[] firstArray = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
//        byte[] secondArray = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();

//        string total = SumArrays(firstArray, secondArray);
//        Console.WriteLine(total);
//    }

//    static string SumArrays(byte[] firstArray, byte[] secondArray)
//    {
//        List<byte> maxArray = new List<byte>();
//        List<byte> minArray = new List<byte>();

//        if (firstArray.Length > secondArray.Length)
//        {
//            maxArray.AddRange(firstArray);
//            minArray.AddRange(secondArray);
//        }
//        else
//        {
//            maxArray.AddRange(secondArray);
//            minArray.AddRange(firstArray);
//        }

//        int minLength = minArray.Count;
//        int maxLength = maxArray.Count;
//        int addition = 0;
//        int sum = 0;
//        var result = new StringBuilder();

//        for (int i = 0; i < minLength; i++)
//        {
//            sum = minArray[i] + maxArray[i] + addition;
//            if (sum >= 10)
//            {
//                addition = 1;
//                sum = sum % 10;
//                result.Append(sum);
//            }
//            else
//            {
//                result.Append(sum);
//                addition = 0;
//            }
//        }

//        for (int j = minLength; j < maxLength; j++)
//        {
//            sum = maxArray[j] + addition;
//            if (sum >= 10)
//            {
//                addition = 1;
//                sum = sum % 10;
//                result.Append(sum);
//            }
//            else
//            {
//                result.Append(sum);
//                addition = 0;
//            }
//        }

//        if (addition == 1)
//        {
//            result.Append(1);
//        }

//        char[] reversed = (result.ToString()).ToCharArray();
//        result.Clear();

//        for (int i = 0; i < reversed.Length; i++)
//        {
//            result.Append(reversed[i]);
//            result.Append(" ");
//        }

//        return result.ToString();
//    }
//}