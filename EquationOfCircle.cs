using System;

namespace AlgebraC__
{
    public static class EquationOfCircle
    {
        public static double GetRadiusOfCircle(double x, double y, double h, double k)
        {
            double radius = Math.Sqrt(Math.Pow((x - h), 2) + Math.Pow((y - k), 2));

            return radius;
        }
    }
}