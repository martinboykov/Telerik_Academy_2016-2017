using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    class BullsandCows
    {
        static void Main()
        {
            int secretNumber = 1481;
            int bulls = 2;
            int caws = 1;
            int count = 0;
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;


            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if (true)
                            {
                                if (true)
                                {
                                    Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4);
                                    count++;
                                }

                            }
                            if (i1 == n1 & i3 == n3 & i4 == n4)
                            {
                                if (i4 == n4)
                                {
                                    Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4);
                                    count++;
                                }

                            }
                        }

                    }
                    Console.WriteLine(count);
                }
            }
        }
    }
}
