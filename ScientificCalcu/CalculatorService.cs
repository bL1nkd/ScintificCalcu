using System;

namespace ScientificCalcu
{
    //class to operate solving
    public class CalculatorService
    {
        private Calculator calculator = new Calculator();
        private ScientificOperations scientific = new ScientificOperations();
        private TrigonometricOperations trigonometric = new TrigonometricOperations();

        public double BasicOperation(string operation, double a, double b)
        {
            if (operation == "+" || operation == "add") return calculator.Add(a, b);
            if (operation == "-" || operation == "subtract") return calculator.Subtract(a, b);
            if (operation == "*" || operation == "multiply") return calculator.Multiply(a, b);
            if (operation == "/" || operation == "divide") return calculator.Divide(a, b);

            if (operation != "+" || operation != "-" || operation != "*" || operation != "/")
            {
                if (operation != "add" || operation != "subtract" || operation != "multiply" || operation != "divide")
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }

            return 0;
        }

        public double Scientific(string operation, double a, double b = 0)
        {
            if (operation == "sqrt") return scientific.SquareRoot(a);
            if (operation == "pow") return scientific.Power(a, b);

            return 0;
        }

        public double Trigonometric(string operation, double angle)
        {
            if (operation == "sin") return trigonometric.Sin(angle);
            if (operation == "cos") return trigonometric.Cos(angle);
            if (operation == "tan") return trigonometric.Tan(angle);
            return 0;
        }
    }
}
