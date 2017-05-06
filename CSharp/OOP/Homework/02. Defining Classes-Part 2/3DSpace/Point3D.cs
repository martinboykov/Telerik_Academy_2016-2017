
public struct Point3D
{
    private static readonly Point3D basePoint = new Point3D(0, 0, 0);
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }

    //construktor
    public Point3D(double x, double y, double z) : this()
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    //static property
    public static Point3D BasePoint
    {
        get
        {
            return basePoint;
        }
    }
    public override string ToString()
    {
        
        return string.Format("[{0}, {1}, {2}]",this.x, this.y, this.z);
         
    }
}
