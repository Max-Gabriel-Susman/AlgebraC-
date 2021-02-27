using System;

namespace AlgebraC__
{
    public static class DistanceBetweenTwoPoints
    {
        public static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return distance;
        }
    }
}