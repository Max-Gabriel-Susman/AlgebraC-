using System;


namespace AlgebraC__
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Math time baby!");

            Console.WriteLine(EquationOfCircle.GetRadiusOfCircle(2,3,4,5));

            Console.WriteLine(DistanceBetweenTwoPoints.GetDistanceBetweenTwoPoints(2,3,4,5));

            Console.WriteLine(QuadraticFormula.Formula(1,-6,5,true));

            Console.WriteLine(QuadraticFormula.Formula(1,-6,5,false));
        }
    }
}
