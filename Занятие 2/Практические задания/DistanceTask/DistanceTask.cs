using System;
 
namespace DistanceTask
{
    public static class DistanceTask
    {
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double a = Math.Sqrt(((x - ax) * (x - ax)) + ((y - ay) * (y - ay)));
            double b = Math.Sqrt(((x - bx) * (x - bx)) + ((y - by) * (y - by)));
            double c = Math.Sqrt(((ax - bx) * (ax - bx)) + ((ay - by) * (ay - by)));
 
            if (x >= ax && x <= bx && b != 0)
            {
 
                                double e = (a + b + c) / 2.0;
                                double f = Math.Sqrt((e * (e - a) * (e - b) * (e - c)));
 
                                return (2.0 * f) / c;
                            }
                    else if ((x <= ax || x >= bx) && c != 0)
                    {
                        return Math.Min(a, b);
                    }
                    else return 0;
        }
    }
}
