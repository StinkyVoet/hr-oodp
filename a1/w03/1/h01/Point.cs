public class Point
{
    public double X, Y;

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static double EuclideanDistance(Point p, Point q)
    {
        return Math.Sqrt(Math.Pow(p.X - q.X, 2) + Math.Pow(p.Y - q.Y, 2));
    }
}