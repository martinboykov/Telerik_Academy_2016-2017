using System;

public static class Distance
{
    public static double distance;
    public static Point3D point1;
    public static Point3D point2;

    public static double Get(Point3D point1, Point3D point2)
    {
        return
           distance = Math.Sqrt(Math.Pow((point2.x - point1.x), y: 2)+ Math.Pow((point2.y - point1.y), 2) + Math.Pow((point2.z - point1.z), 2));
    }
}