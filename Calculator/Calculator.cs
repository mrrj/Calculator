using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
     
        public double Addition(List<double> numbers)
        {
            double x = 0;
            foreach (double y in numbers)
            {
                x += y;
            }
            return x;
        }

        public double Addition(double[] numbers)
        {
            double x = 0;
            foreach (double y in numbers)
            {
                x += y;
            }
            return x;
        }

        public double Subtraction(List<double> numbers)
        {
            double x = 2 * numbers[0];
            foreach (double y in numbers)
            {
                x -= y;
            }
            return x;
        }

        public double Subtraction(double[] numbers)
        {
            double x = 2 * numbers[0];
            foreach (double y in numbers)
            {
                x -= y;
            }
            return x;
        }
        public double Multiplication(double[] numbers)
        {
            double x = 1;
            foreach (double y in numbers)
            {
                x *= y;
            }
            return x;
        }


        public double Division(List<double> numbers)
        {
            double x = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] == 0)
                {
                    throw new DivideByZeroException();
                }

                x /= numbers[i];
            }

            return x;
        }
        public double Multiplication(List<double> numbers)
        {
            double x = 1;
            foreach (double y in numbers)
            {
                x *= y;
            }
            return x;
        }
 
      
        public double Division(double[] numbers)
        {
            double x = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] == 0)
                {
                    throw new DivideByZeroException();
                }

                x /= numbers[i];
            }

            return x;
        }


    }
}
