using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {

        static List<double> numbers = new List<double>();
        static double result;

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
                                result = Addition(numbers);
                                PrintResult('+');
                            }
                            break;
                        case 2:
                            //Subtract
                            if (InitOperation("subtract"))
                            {
                                result = Subtraction(numbers);
                                PrintResult('-');
                            }
                            break;
                        case 3:
                            //Multiply
                            if (InitOperation("multiply"))
                            {
                                result = Multiplication(numbers);
                                PrintResult('*');
                            }
                            break;
                        case 4:
                            //Divide
                            if (InitOperation("divide"))
                            {
                                result = Division(numbers);
                                PrintResult('/');
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

        static bool InitOperation(string op)
        {
            Console.WriteLine("Enter numbers to " + op + " separated by blank space");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(" ");

            foreach(string str in splitInput)
            {
                if(double.TryParse(str, out double number))
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

        static double Addition(List<double> numbers)
        {
            double x = 0;
            foreach(double y in numbers)
            {
                x += y;
            }
            return x;
        }

        static double Subtraction(List<double> numbers)
        {
            double x = 2*numbers[0];
            foreach (double y in numbers)
            {
                x -= y;
            }
            return x;
        }

        static double Multiplication(List<double> numbers)
        {
            double x = 1;
            foreach (double y in numbers)
            {
                x *= y;
            }
            return x;
        }

        static double Division(List<double> numbers)
        {
            double x = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    int numberOfElements = numbers.Count - i;
                    numbers.RemoveRange(i,numberOfElements);
                }
                else
                {
                    x /= numbers[i];
                }
            }

            return x;
        }

        static void PrintResult(char c)
        {
            int size = numbers.Count - 1;
            for(int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " " + c + " ");
            }
            Console.WriteLine(numbers[size] + " = " + result);
        }
    }
}

