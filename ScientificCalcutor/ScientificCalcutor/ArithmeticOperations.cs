using System;

namespace ScientificCalcutor
{
    public class ArithmeticOperations
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return double.NaN;
            }
            return a / b;
        }
    }
}
