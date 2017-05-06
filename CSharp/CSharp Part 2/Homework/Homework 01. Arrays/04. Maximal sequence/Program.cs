using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int count = 0;
            int countMax = 0;
            array1[0] = int.Parse(Console.ReadLine());
                        int current = array1[0];
                        for (int i = 1; i<N; i++)
                        {
                            array1[i] = int.Parse(Console.ReadLine());
                            if (array1[i] != current)
                            {
                                count = 0;
                                current = array1[i];
                                count++;
                            }
                            else
                            {
                                count++;
                                if (count > countMax)
                                {
                                    countMax = count;
                                }
                            }
                        }
                        Console.WriteLine(countMax);
        }
    }
}





//int N = int.Parse(Console.ReadLine());
////with Lists
//List<int> intList1 = new List<int>();
//intList1.Add(int.Parse(Console.ReadLine()));
//            //List<int> intListCurrent = new List<int>();
//            List<int> intListCurrent = new List<Int32>(intList1);
////List<int> intListMax = new List<int>();
//List<int> intListMax = new List<Int32>(intListCurrent);
//            //intListCurrent.Add(intList1[0]);
//            //intListMax.Add(intListCurrent[0]);
//            for (int i = 1; i<N; i++)
//            {
//                intList1.Add(int.Parse(Console.ReadLine()));
//                if (intList1[i] != intListCurrent.Last())
//                {
//                    intListCurrent.Clear();
//                    intListCurrent.Add(intList1[i]);
//                }
//                else
//                {
//                    intListCurrent.Add(intList1[i]);
//                    if (intListCurrent.Count > intListMax.Count)
//                    {

//                        intListMax = intListCurrent.ToList(); /* ".ToList()" is the same as "new List<Int32>(intListCurrent)";*/
//                    }
//                }
//            }
//            Console.WriteLine(intListMax.Count);
//            //Console.Write("The longest sequence of same numbers is: ");
//            //foreach (var item in intListMax)
//            //{
//            //    Console.Write("{0} ", item);
//            //}
//            //Console.WriteLine();