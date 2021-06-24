using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Program
    {

        private static List<double> numbers = new List<double>();
        private static double result;

        static void Main(string[] args)
        {
            
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Welcome! What would you like to do?");
                Console.Write(
                    "0. Exit \n" +
                    "1. Addition \n" +
                    "2. Subtraction \n" +
                    "3. Multiplication \n" +
                    "4. Division \n");
                string selection = Console.ReadLine();
                if (int.TryParse(selection, out int operationChoice))
                {
                    switch (operationChoice)
                    {
                        case 0:
                            keepRunning = false;
                            break;
                        case 1:
                            //Add
                            if (InitOperation("add"))
                            {
                                result = Calculator.Addition(numbers);
                                PrintResult('+');
                            }
                            break;
                        case 2:
                            //Subtract
                            if (InitOperation("subtract"))
                            {
                                result = Calculator.Subtraction(numbers);
                                PrintResult('-');
                            }
                            break;
                        case 3:
                            //Multiply
                            if (InitOperation("multiply"))
                            {
                                result = Calculator.Multiplication(numbers);
                                PrintResult('*');
                            }
                            break;
                        case 4:
                            //Divide
                            if (InitOperation("divide"))
                            {
                                try {
                                    result = Calculator.Division(numbers);
                                    PrintResult('/');
                                }
                                    
                                catch(DivideByZeroException)
                                {
                                    Console.WriteLine("Cannot divide by zero");
                                }

                            }
                            break;
                        default:
                            Console.WriteLine("Please choose an item in the menue.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                numbers.Clear();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }


        }

        public static bool InitOperation(string op)
        {
            Console.WriteLine("Enter numbers to " + op + " separated by blank space");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(" ");

            foreach (string str in splitInput)
            {
                if (double.TryParse(str, out double number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
            }
            return true;

        }

        public static void PrintResult(char c)
        {
            int size = numbers.Count - 1;
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " " + c + " ");
            }
            Console.WriteLine(numbers[size] + " = " + result);
        }


    }
}

