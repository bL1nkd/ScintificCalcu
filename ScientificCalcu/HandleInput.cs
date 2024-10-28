using System;

namespace ScientificCalcu
{
    //class to input
    public class HandleInput
    {
        private CalculatorService service = new CalculatorService();

        public void Start()
        {
            Console.WriteLine("Simple Scientific Calculator");

            while (true)
            {
                Console.Write("Enter first number: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter operation (+, -, *, /, sqrt, pow, sin, cos, tan): ");
                string operation = Console.ReadLine().ToLower();

                if (operation == "sin" || operation == "cos" || operation == "tan")
                {
                    double result = service.Trigonometric(operation, a);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "sqrt")
                {
                    double result = service.Scientific(operation, a);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "pow")
                {
                    Console.Write("Enter second number (exponent): ");
                    double b = double.Parse(Console.ReadLine());
                    double result = service.Scientific(operation, a, b);
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.Write("Enter second number: ");
                    double b = double.Parse(Console.ReadLine());
                    double result = service.BasicOperation(operation, a, b);
                    Console.WriteLine("Result: " + result);
                }

                Console.WriteLine("Type 'exit' to quit or press any key to continue using.");
                if (Console.ReadLine().ToLower() == "exit") break;
            }
        }
    }
}
