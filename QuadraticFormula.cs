using System;

namespace AlgebraC__
{
    public static class QuadraticFormula
    {
        // give the fourth argument a value of true to subtract the discriminant, false to add it
        public static double Formula(double a, double b, double c, bool subtractingDiscriminant)
        {
            int switchOperand = (subtractingDiscriminant) ? -1 : 1;

            double x = (-b + ((switchOperand)*(Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))))) / (2 * a);

            return x;
        }
    }
}