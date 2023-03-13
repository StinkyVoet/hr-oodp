public class Point
{
    public double X, Y;

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Point() : this(0, 0){}
    
    public Point(Point p) : this(p.X, p.Y){}

    public static double EuclideanDistance(Point p, Point q)
    {
        return Math.Sqrt(Math.Pow(p.X - q.X, 2) + Math.Pow(p.Y - q.Y, 2));
    }
}