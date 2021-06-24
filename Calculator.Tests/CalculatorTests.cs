using System;
using System.Collections.Generic;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AdditionWithZero()
        {

            double[] numbers = new double[] { 2, 8, 5 };
            double[] numbers0 = new double[] { 2, 0, 8, 5 };

            double addNumbers = Calculator.Addition(numbers);
            double addNUmbersWithZero = Calculator.Addition(numbers0);

            //addition with zero should return the same number
            Assert.Equal<double>(addNumbers, addNUmbersWithZero);
          
        }

        [Fact]
        public void SubtractionWithZero()
        {
            double[] numbers = new double[] { 11, 8 };
            double[] numbers0 = new double[] { 11, 0, 8 };

            double subtractNumbers = Calculator.Subtraction(numbers);
            double subtractNumbersWithZero = Calculator.Subtraction(numbers0);

            //subtraction with zero should return the same number
            Assert.Equal<double>(subtractNumbers,subtractNumbersWithZero);

        }

        [Fact]
        public void SubtractionWithNegatives()
        {
            double[] numbers = new double[] { 11, 8, (-9) };

            double subtractNumbers = Calculator.Subtraction(numbers);
            double addNumbers = 11 - 8 + 9;

            //subtracting a negative should be equal to addition
            Assert.Equal<double>(subtractNumbers, addNumbers);

        }


        [Fact]
        public void MultiplicationByZero()
        {
            double[] numbers = new double[] { 5, 0, 11 };

            double multiplyByZero = Calculator.Multiplication(numbers);

            //multiplication by zero should return zero
            Assert.Equal<double>(0, multiplyByZero);
        }

        [Fact]
        public void MultiplicationByOne()
        {
            double[] numbers = new double[] { 5, 22 };
            double[] numbers1 = new double[] { 5, 22, 1 };

            double mutliplyNumbers = Calculator.Multiplication(numbers);
            double mutliplyNumbersByOne = Calculator.Multiplication(numbers1);

            //multiplication by one should return the same number
            Assert.Equal<double>(mutliplyNumbers,mutliplyNumbersByOne);
        }

        [Fact]
        public void MultiplicationTest()
        {
            double[] numbers = new double[] { 10, 5, 2 };

            double multiplyNumbers = Calculator.Multiplication(numbers);

            //result of multiplication should be 100
            Assert.Equal<double>(100, multiplyNumbers);
        }

        [Fact]
        public void MultiplyNegatives()
        {
            double[] numbersPositive = new double[] { 5, 7 };
            double[] numbersNegative = new double[] { (-5), (-7) };

            double multiplyPositives = Calculator.Multiplication(numbersPositive);
            double multiplyNegatives = Calculator.Multiplication(numbersNegative);

            //multiplying two negatives should yield the same result as positives
            Assert.Equal<double>(multiplyPositives, multiplyNegatives);
        }

        [Fact]
        public void DivisionByOne()
        {
            double[] numbers = new double[] { 7, 8 };
            double[] numbers1 = new double[] { 7, 8, 1 };

            double divideNumbers = Calculator.Division(numbers);
            double divideByOne = Calculator.Division(numbers1);

            //division by one should return the same number

            Assert.Equal<double>(divideNumbers, divideByOne);
        }

        [Fact]
        public void DivisionByZero()
        {
            double[] numbers = new double[] { 5, 7, 0 };

            //division by zero should throw DivideByZeroException
            Assert.Throws<DivideByZeroException>(() => Calculator.Division(numbers));

        }



    }
}
