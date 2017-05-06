using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class
{
    class TEST
    {
        static void Main(string[] args)
        {
            // Declare a list of type int 
            GenericList<int> intList = new GenericList<int>();
            intList.Add(0);
            intList.Add(11);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            Console.WriteLine(intList.Capacity);
            Console.WriteLine(intList.Length);
            Console.WriteLine(intList[1]);
            intList.Remove(1);
            Console.WriteLine(intList.Capacity);
            Console.WriteLine(intList.Length);
            intList.Insert(1, 1);
            Console.WriteLine();
            Console.WriteLine(intList.Find(12));
            Console.WriteLine(intList.Capacity);
            Console.WriteLine(intList.Length);
            intList.Clear();
            Console.WriteLine(intList.Capacity);
            Console.WriteLine(intList.Length);
            
            intList.DoubleListSize();
            Console.WriteLine(intList.Capacity);
            Console.WriteLine(intList.Length);
            Console.WriteLine();
            intList.Add(123);
            intList.Add(111);
            intList.Add(154);
            Console.WriteLine(intList.ToString());
            Console.WriteLine(intList.Min());
            Console.WriteLine(intList.Max()); 
        }
    }
}
