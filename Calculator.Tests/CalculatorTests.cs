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

            Calculator calc = new Calculator();
            List<double> numbers = new List<double> { 2, 8 };
            List<double> numbers0 = new List<double>() { 2, 0, 8 };

            //addition with zero should return the same number
            Assert.Equal<double>(calc.Addition(numbers), calc.Addition(numbers0));
          
        }

        [Fact]
        public void SubtractionWithZero()
        {
            Calculator calc = new Calculator();
            List<double> numbers = new List<double> { 11, 8 };
            List<double> numbers0 = new List<double>() { 11, 0, 8 };

            //subtraction with zero should return the same number
            Assert.Equal<double>(calc.Subtraction(numbers), calc.Subtraction(numbers0));

        }

        [Fact]
        public void SubtractionWithNegatives()
        {
            Calculator calc = new Calculator();
            double[] numbers = new double[] { 11, 8, (-9) };
            double subtractNumbers = calc.Subtraction(numbers);
            double addNumbers = 11 - 8 + 9;

            //subtracting a negative should be equal to addition
            Assert.Equal<double>(calc.Subtraction(numbers), addNumbers);

        }


        [Fact]
        public void MultiplicationWtihZero()
        {
            Calculator calc = new Calculator();
            double[] numbers = new double[] { 5, 0, 11 };

            //multiplication with zero should return zero
            Assert.Equal<double>(0, calc.Multiplication(numbers));
        }

        [Fact]
        public void MultiplicationWtihOne()
        {
            Calculator calc = new Calculator();
            double[] numbers = new double[] { 5, 22 };
            double[] numbers1 = new double[] { 5, 22, 1 };

            //multiplication with one should return the same number
            Assert.Equal<double>(calc.Multiplication(numbers), calc.Multiplication(numbers1));
        }

        [Fact]
        public void MultiplyNegatives()
        {
            Calculator calc = new Calculator();
            double[] numbersPositive = new double[] { 5, 7 };
            double[] numbersNegative = new double[] { (-5), (-7) };

            //multiplying two negatives should yield the same result as positives
            Assert.Equal<double>(calc.Multiplication(numbersPositive), calc.Multiplication(numbersNegative));
        }

        [Fact]
        public void DivisionByOne()
        {
            Calculator calc = new Calculator();

            //division by one should return the same number
            double[] numbers = new double[] { 7, 8 };
            double[] numbers1 = new double[] { 7, 8, 1 };
            Assert.Equal<double>(calc.Division(numbers), calc.Division(numbers1));
        }

        [Fact]
        public void DivisionByZero()
        {
            Calculator calc = new Calculator();
            double[] numbers = new double[] { 5, 7, 0 };

            //division by zero should throw DivideByZeroException
            Assert.Throws<DivideByZeroException>(() => calc.Division(numbers));

        }



    }
}
