using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2___Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //List<int> intList = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    intList.Add(i);
            //    Console.Write("{0} ", intList[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Is the same as...");
            //int[] intArray = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    intArray[i] = i;
            //    Console.Write("{0} ", intArray[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //Demo 1 - Lists.cs
            //List<string> listOfStrings = new List<string>();
            //string[] arrayOfStrings = { "Pesho", "Ivan", "Dobri", "Gosho" };
            //foreach (string str in arrayOfStrings)
            //{
            //    listOfStrings.Add(str);
            //}

            //Console.WriteLine("Using \"foreach\" loop to traverse the List");
            //Console.WriteLine(new string('-', 50));
            //foreach (string str in listOfStrings)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine(new string('-', 50));
            //Console.WriteLine("Using \"for\" loop to traverse the List");
            //Console.WriteLine(new string('-', 50));
            //for (int i = 0; i < listOfStrings.Count; i++)
            //{
            //    Console.WriteLine(listOfStrings[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();





            //Demo 2 ResizingLists.cs
            //List<int> list = new List<int>();
            //int n = int.Parse(Console.ReadLine());

            //string lineBreak = new string('-', 20);

            //for (int i = 0; i < n + 1; i++)
            //{
            //    var capacity = list.Capacity;
            //    var count = list.Count;
            //    Console.WriteLine("Total Capacity of the List: {0}\nused:{1}\n{2}",
            //        capacity, count, lineBreak);
            //    list.Add(i);
            //}

            //List.Insert(5,132) Inserts integer 123 at position 5.
            //AddRange (array)
            //List.Insert() remove element
            //list.Sort подрежда списъка
            //list.Add добавя елемент



            ////Извежда всички стрингове започващи с буквата R
            //List<string> listofStrings = new List<string>();
            //listofStrings.Add("Bulgaria");
            //listofStrings.Add("Romania");
            //listofStrings.Add("Greece");
            //listofStrings = listofStrings
            //    .Where(x => x[0] == 'R') //x=> означава x отива в....(където x[0]=='R')
            //    .ToList();
            //foreach (var item in listofStrings)
            //{
            //    Console.WriteLine(item);
            //}


            ////Подрежда елементите по дължината им
            //List<string> listofStrings = new List<string>();
            //listofStrings.Add("Bulgaria");
            //listofStrings.Add("Romania");
            //listofStrings.Add("Greece");
            //listofStrings = listofStrings
            //    .OrderBy(x => x.Length)
            //    .ToList();
            //foreach (var item in listofStrings)
            //{
            //    Console.WriteLine(item);
            //}



            ////How ToList() work
            //string[] array = new string[]
            //{
            //    "A",
            //    "B",
            //    "C",
            //    "D"
            //};
            //List<string> list = array.ToList();
            ////
            //// Display the list.
            ////
            //Console.WriteLine(list.Count);
            //foreach (string value in list)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine();
            //string[] array1 = new string[]
            //{
            //    "E",
            //    "F",
            //    "G",
            //    "H"
            //};
            //list = array1.ToList();
            ////
            //// Display the list.
            ////
            //Console.WriteLine(list.Count);
            //foreach (string value in list)
            //{
            //    Console.WriteLine(value);
            //}



            //// Generate a sequence of three integers starting at 4, 
            //// and then select their squares.
            //IEnumerable<int> squares = Enumerable.Range(4, 3).Select(x => x * x);

            //foreach (int num in squares)
            //{
            //    Console.WriteLine(num);
            //}

            ///*
            // This code produces the following output:
            // 16
            // 25
            // 36
            //*/



        }
    }
}
