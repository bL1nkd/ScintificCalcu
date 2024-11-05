using System;

namespace ScientificCalcutor
{
    public class ScientificOperations
    {
        public double SquareRoot(double a) => Math.Sqrt(a);
        public double Power(double baseNum, double exponent) => Math.Pow(baseNum, exponent);
        public double Sine(double angle) => Math.Sin(angle);
        public double Cosine(double angle) => Math.Cos(angle);
        public double Tangent(double angle) => Math.Tan(angle);
    }
}
