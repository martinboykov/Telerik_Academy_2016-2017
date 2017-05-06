using System;

class Batman
{
    static void Main()
    {
        //var intArray = new int[5];
        //for (int i = 0; i < intArray.Length; i++)
        //{
        //    intArray[i] = i;
        //    Console.Write("{0} ", intArray[i]);
        //}
        //Console.WriteLine();
        //var newArray = intArray; //arrays have dynamic memory
        //Console.WriteLine(newArray== intArray);
        //for (int i = 0; i < intArray.Length; i++)
        //{

        //    Console.Write("{0} ", newArray[i]);
        //}
        //Console.WriteLine();
        //newArray[0] = 5; //arrays have dynamic memory
        //for (int i = 0; i < intArray.Length; i++)
        //{

        //    Console.Write("{0} ", newArray[i]);
        //}
        //Console.WriteLine();
        //for (int i = 0; i < intArray.Length; i++)
        //{

        //    Console.Write("{0} ", intArray[i]);
        //}
        //Console.WriteLine();
        //Console.WriteLine(newArray == intArray);//arrays have dynamic memory
        //intArray[0] = 1;//arrays have dynamic memory
        //for (int i = 0; i < intArray.Length; i++)
        //{

        //    Console.Write("{0} ", newArray[i]);
        //}
        //Console.WriteLine();
        //for (int i = 0; i < intArray.Length; i++)
        //{

        //    Console.Write("{0} ", intArray[i]);
        //}
        //Console.WriteLine();
        //Console.WriteLine(newArray == intArray);//arrays have dynamic memory
        ////var theNewestArray = newArray + intArray; + cant be applyed
        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();
        //var theNewestArray = new int [5];
        //for (int i = 0; i < theNewestArray.Length; i++)
        //{
        //    theNewestArray[i] = newArray[i];
        //    Console.Write("{0} ", theNewestArray[i]);
        //}
        //Console.WriteLine();
        //theNewestArray[0] = 46;
        //for (int i = 0; i < theNewestArray.Length; i++)
        //{
        //    Console.Write("{0} ", theNewestArray[i]);
        //}
        //Console.WriteLine();
        //for (int i = 0; i < newArray.Length; i++)
        //{
        //    Console.Write("{0} ", newArray[i]);
        //}
        //Console.WriteLine();
        //Console.WriteLine("Reversed Array");//reverced array
        //Console.WriteLine();
        //var revArray = new int[intArray.Length];
        //for (int index = 0; index < intArray.Length; index++)
        //{
        //    revArray[newArray.Length - index - 1] = intArray[index];
        //    Console.Write("{0} ", intArray[index]);
        //}
        //Console.WriteLine();
        //for (int index = 0; index < intArray.Length; index++)
        //{
        //    Console.Write("{0} ", revArray[index]);
        //}



        int[] array = { 1, 2, 3, 4, 5 };
        int[] copyArray = (int[])array.Clone();

        foreach (var item in copyArray)
        {
            Console.Write("{0} ",item);
        }
    }
}