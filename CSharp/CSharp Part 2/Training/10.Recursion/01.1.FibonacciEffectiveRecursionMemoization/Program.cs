using System;
class RecursiveFibonacciMemoization
{
    static long[] numbers;
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        numbers = new long[n + 1];
        numbers[1] = 1;
        numbers[2] = 1;
        long result = Fib(n);
        Console.WriteLine("fib({0}) = {1}", n, result);
    }
    static long Fib(int n)
    {
        Console.Write("{0} ", n);
        if (0 == numbers[n])
        {
            numbers[n] = Fib(n - 1) + Fib(n - 2);
            
        }
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write("{0} ", numbers[i]);
        //}
        //Console.WriteLine();
        Console.WriteLine();
        return numbers[n];
    }
}