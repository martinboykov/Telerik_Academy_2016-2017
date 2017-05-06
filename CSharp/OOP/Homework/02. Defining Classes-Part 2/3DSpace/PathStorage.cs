using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

namespace _3DSpace
{
    public static class PathStorage
    {
        public static void Save(Path path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("../../Saves.txt"))
                {
                    foreach (var point in Path.Points)
                    {
                        writer.WriteLine(point);
                    }
                    Console.WriteLine("The new path was saved!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public static Path Load()
        {
            Path points = new Path();
            
            try
            {
                using (StreamReader reader = new StreamReader("../../Saves.txt"))
                {
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine();
                        string[] splitted = line.Split(new char[] { ' ', '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);
                        points.AddPoint(new Point3D(double.Parse(splitted[0]), double.Parse(splitted[1]), double.Parse(splitted[2])));
                    }
                    Console.WriteLine("Loading the new path...");
                    return points;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            return null;
        }
    }
}