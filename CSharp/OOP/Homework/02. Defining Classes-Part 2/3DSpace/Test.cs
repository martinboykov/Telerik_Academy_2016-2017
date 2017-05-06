using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace _3DSpace
{
    class TEST
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Point3D point1 = new Point3D { x = 5, y = -3, z = 5 };
            Console.WriteLine(point1);
            Point3D point2 = new Point3D { x = -5, y = 3, z = 15 };
            Console.WriteLine(point2);
            
            Console.WriteLine("The distance between {0} and {1} is {2:F3}", point1, point2, Distance.Get(point1, point2));

            List<Point3D> points = new List<Point3D>();
            points.Add(point1);
            points.Add(point2);
            points.Remove(points[1]);
            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }
            Path testPath = new Path();
            testPath.AddPoint(Point3D.BasePoint);
            testPath.AddPoint(point1);
            testPath.AddPoint(new Point3D(2.54, 3.65, 9.54));
            Console.WriteLine();
            testPath.PrintPath(); // access static field through unstatic method 
            Console.WriteLine();
            foreach (Point3D point in Path.Points) //access static field through his class
            {
                Console.WriteLine("[{0}, {1}, {2}]", point.x, point.y, point.z);
            }
            Console.WriteLine();
            PathStorage.Save(testPath);
            Console.WriteLine(PathStorage.Load());
            
        }
    }
}

