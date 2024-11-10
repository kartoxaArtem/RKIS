using Geometry;

namespace Geometry
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Vector other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static double CrossProduct(Vector v1, Vector v2)
        {
            return v1.X * v2.Y - v1.Y * v2.X;
        }
    }
}