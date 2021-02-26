using System;

namespace AlgebraC__
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Math time baby!");

            double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
            {
                double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

                return distance;
            }

            Console.WriteLine(DistanceBetweenTwoPoints(2,3,4,5));
        }
    }
}
