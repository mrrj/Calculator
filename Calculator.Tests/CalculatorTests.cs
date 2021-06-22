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



            //addition with zero should return the same number
            List<double> numbers = new List<double> { 2, 8 };
            List<double> numbers0 = new List<double>() { 2, 0, 8 };
            Assert.Equal<double>(calc.Addition(numbers), calc.Addition(numbers0));
          
        }

        [Fact]
        public void SubtractionWithZero()
        {
            Calculator calc = new Calculator();

            //subtraction with zero should return the same number
            List<double> numbers = new List<double> { 11, 8 };
            List<double> numbers0 = new List<double>() { 11, 0, 8 };
            Assert.Equal<double>(calc.Subtraction(numbers), calc.Subtraction(numbers0));

        }

        [Fact]
        public void MultiplicationWtihZero()
        {
            Calculator calc = new Calculator();

            //multiplication with zero should return zero
            List<double> numbers = new List<double> { 5, 0, 11 };
            Assert.Equal<double>(0, calc.Multiplication(numbers));
        }

        [Fact]
        public void MultiplicationWtihOne()
        {
            Calculator calc = new Calculator();

            //multiplication with one should return the same number
            List<double> numbers = new List<double> { 5, 22 };
            List<double> numbers1 = new List<double> { 5, 22, 1 };
            Assert.Equal<double>(calc.Multiplication(numbers), calc.Multiplication(numbers1));
        }

        [Fact]
        public void DivisionByOne()
        {
            Calculator calc = new Calculator();

            //division by one should return the same number
            List<double> numbers = new List<double> { 7, 8 };
            List<double> numbers1 = new List<double> { 7, 8, 1 };
            Assert.Equal<double>(calc.Division(numbers), calc.Division(numbers1));
        }

        [Fact]
        public void DivisionByZero()
        {
            Calculator calc = new Calculator();

            //division by zero should throw DivideByZeroException
            List<double> numbers = new List<double> { 5, 7, 0 };
            Assert.Throws<DivideByZeroException>(() => calc.Division(numbers));

        }
    }
}
