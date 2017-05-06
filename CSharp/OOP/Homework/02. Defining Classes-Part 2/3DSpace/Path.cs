using System;
using System.Collections.Generic;

namespace _3DSpace
{
    public class Path
    {

        public static readonly List<Point3D> Points = new List<Point3D>();

        //constructor
        public Path()
        {
        }
        public int Count
        {
            get
            {
                return Points.Count;
            }
        }

        //property
        //public Point3D this[int index]
        //{
        //    get
        //    {
        //        return Points[index];
        //    }
        //    set
        //    {
        //       Points[index] = value;
        //    }
        //}

        //method
        public void AddPoint(Point3D point)
        {
            Points.Add(point);
        }

        //public void AddPoints(ICollection<Point3D> p)
        //{
        //    points.AddRange(p);
        //}

        public void AddPoints(params Point3D[] p)
        {
           Points.AddRange(p);
        }


        public void RemovePoint(int index)
        {
            Points.Remove(Points[index]);
        }

        public void ClearPath()
        {
           Points.Clear();
        }

        public void PrintPath()
        {
            foreach (Point3D point in Points)
            {
                Console.WriteLine("[{0}, {1}, {2}]", point.x, point.y, point.z);
            }
        }
        public override string ToString()
        {
            return String.Join("; ", Points);
        }

       
    }
}