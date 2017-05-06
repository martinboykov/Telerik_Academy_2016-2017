using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P._03._2013._02.V2_Laser_2
{
    class Program
    {
        static int[] GetThreeNumbersFromConsole()
        {
            return Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        }
        static void Main(string[] args)
        {
            int[] dim = GetThreeNumbersFromConsole();
            int[] pos = GetThreeNumbersFromConsole();
            int[] vec = GetThreeNumbersFromConsole();
            bool[,,] visited = new bool[dim[0] + 1, dim[1] + 1, dim[2] + 1];
            while (true)
            {
                visited[pos[0], pos[1], pos[2]] = true;
                int[] newPos = new int[3];
                //pos: 2,2,2
                //vect: 1,0,-1
                //newPos: 3,2,1
                for (int i = 0; i < newPos.Length; i++)
                {
                    newPos[i] = pos[i] + vec[i];
                }
                if (visited[newPos[0], newPos[1], newPos[2]] || HowManyIndexesAreAtLinmit(newPos, dim) >= 2) //2 - ръб ; 3 - ъгъл
                {
                    Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);
                    break;
                }
                if (HowManyIndexesAreAtLinmit(newPos, dim) == 1)
                {
                    // we have hit a wall
                    //at 2,0,1
                    //vect 1,-1,1
                    //neet to reverse or we exit the cube
                    ReverseComponent(newPos, vec, dim);
                }
                for (int i = 0; i < 3; i++)
                {
                    pos[i] = newPos[i];
                }
            }
        }

        private static void ReverseComponent(int[] newPos, int[] vec, int[] dim)
        {
            for (int i = 0; i < 3; i++)
            {
                if (newPos[i] == 1 && vec[i]==-1)
                {
                    vec[i] *= -1;
                }
                if (newPos[i] == dim[i] && vec[i] == 1)
                {
                    vec[i] *= -1;
                }
            }
        }

        static int HowManyIndexesAreAtLinmit(int[] pos, int[] dim)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {

                if (pos[i] == 1 || pos[i] == dim[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
