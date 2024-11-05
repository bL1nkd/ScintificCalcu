using System;

namespace ScientificCalcutor
{
    public class UI
    {
        private ArithmeticOperations _arithmetic = new ArithmeticOperations();
        private ScientificOperations _scientific = new ScientificOperations();

        public void Start()
        {
            Console.WriteLine("<-------------|| Welcome to the Scientific Calculator! ||------------->");

            while (true)
            {
                Console.WriteLine("\nCHOOSE AN OPERATION:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Square Root (sqrt)");
                Console.WriteLine("6. Power (^)");
                Console.WriteLine("7. Sine (sin)");
                Console.WriteLine("8. Cosine (cos)");
                Console.WriteLine("9. Tangent (tan)");
                Console.WriteLine("0. Exit");

                Console.Write("\nENTER NUMBER OF OPERATION: ");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                double result = 0;
                try
                {
                    result = PerformOperation(choice);
                    Console.WriteLine($"RESULT: {result}");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        private double PerformOperation(string choice)
        {
            switch (choice)
            {
                case "1": // Addition
                    return PerformBinaryOperation(_arithmetic.Add);
                case "2": // Subtraction
                    return PerformBinaryOperation(_arithmetic.Subtract);
                case "3": // Multiplication
                    return PerformBinaryOperation(_arithmetic.Multiply);
                case "4": // Division
                    return PerformBinaryOperation(_arithmetic.Divide);
                case "5": // Square Root
                    Console.Write("Enter a number: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    return _scientific.SquareRoot(num);
                case "6": // Power
                    Console.Write("Enter the base number: ");
                    double baseNum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the exponent: ");
                    double exponent = Convert.ToDouble(Console.ReadLine());
                    return _scientific.Power(baseNum, exponent);
                case "7": // Sine
                    Console.Write("Enter an angle in radians: ");
                    double angle = Convert.ToDouble(Console.ReadLine());
                    return _scientific.Sine(angle);
                case "8": // Cosine
                    Console.Write("Enter an angle in radians: ");
                    angle = Convert.ToDouble(Console.ReadLine());
                    return _scientific.Cosine(angle);
                case "9": // Tangent
                    Console.Write("Enter an angle in radians: ");
                    angle = Convert.ToDouble(Console.ReadLine());
                    return _scientific.Tangent(angle);
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    return double.NaN;
            }
        }

        private double PerformBinaryOperation(Func<double, double, double> operation)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return operation(num1, num2);
        }
    }
}
