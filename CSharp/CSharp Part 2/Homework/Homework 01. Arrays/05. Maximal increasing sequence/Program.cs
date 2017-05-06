using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());//number of cars
            bool catchCar = false;
            int currentSpeed = int.MaxValue;
            int carGroup = 1;
            int carLongestGroup = 1;
            int SumInitialSpeeds = 0;
            int SumInitialSpeedsLongest = 0;
            for (int i = 0; i < N; i++)
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
                    carGroup = 1;
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

                if (carLongestGroup != 1) continue;
                if (SumInitialSpeedsLongest < S)
                {
                    SumInitialSpeedsLongest = S;
                }
            }
            Console.WriteLine(carLongestGroup);
        }
    }
}

//int n = int.Parse(Console.ReadLine());