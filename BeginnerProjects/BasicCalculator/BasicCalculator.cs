using System;

namespace BeginnerProjects.BasicCalculator
{
    class BasicCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator");

            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Enter another number: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Enter an operation (+, -, *, /): ");
                    string option = Console.ReadLine();

                    double result = 0;

                    switch (option)
                    {
                        case "+":
                            result = a + b;
                            Console.WriteLine($"The sum of {a} and {b} is: {result}");
                            break;
                        case "-":
                            result = a - b;
                            Console.WriteLine($"The difference between {a} and {b} is: {result}");
                            break;
                        case "*":
                            result = a * b;
                            Console.WriteLine($"The product of {a} and {b} is: {result}");
                            break;
                        case "/":
                            if (b == 0)
                            {
                                Console.WriteLine("Error: Cannot divide by zero.");
                            }
                            else
                            {
                                result = a / b;
                                Console.WriteLine($"The quotient of {a} divided by {b} is: {result}");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid operation. Please enter one of +, -, *, /.");
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }

                Console.Write("Do you want to perform another calculation? (yes/no): ");
                string continueCalculation = Console.ReadLine().ToLower();

                if (continueCalculation != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the Basic Calculator.");
        }
    }
}
