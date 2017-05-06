using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);
            int C = int.Parse(Console.ReadLine());//number of cars
            bool catchCar = false;
            int currentSpeed = int.MaxValue;
            int carGroup = 0;
            int carLongestGroup = 0;
            int SumInitialSpeeds = 0;
            int SumInitialSpeedsLongest = 0;
            for (int i = 0; i < C; i++)
            {
                int S = int.Parse(Console.ReadLine());//initial speed of car_i

                if (S > currentSpeed)
                {
                    catchCar = true;
                    carGroup++;
                    SumInitialSpeeds += S;
                }
                else
                {
                    currentSpeed = S;
                    catchCar = false;
                    carGroup = 0;
                    SumInitialSpeeds = currentSpeed;
                }

                if (catchCar)
                {
                    if (carGroup > carLongestGroup)
                    {
                        carLongestGroup = carGroup;
                        SumInitialSpeedsLongest = SumInitialSpeeds;

                    }
                    else if (carGroup == carLongestGroup)
                    {
                        if (SumInitialSpeeds > SumInitialSpeedsLongest)
                        {
                            SumInitialSpeedsLongest = SumInitialSpeeds;
                        }
                    }
                }

                if (carLongestGroup == 0)
                {
                    if (SumInitialSpeedsLongest < S)
                    {
                        SumInitialSpeedsLongest = S;
                    }
                }
            }
            Console.WriteLine(SumInitialSpeedsLongest);
        }
    }
}

//int n = int.Parse(Console.ReadLine());