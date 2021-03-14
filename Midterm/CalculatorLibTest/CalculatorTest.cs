/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/15/2021
/// Assignment:  Midterm
/// Purpose:     Adapted from Homework 3. This test class will show that the functions in the
///              Calculator class work properly
/// </summary>

using CalculatorLib;
using System;
using Xunit;

namespace CalculatorLibTest
{
    /// <summary>
    /// This class will maintain the testing functions
    /// for the Calculator class
    /// </summary>
    public class CalculatorTest
    {
        /// <summary>
        /// This test will validate the Add function
        /// </summary>
        [Fact]
        public void TestAdd2And4()
        {
            // Arrange
            double a = 2;
            double b = 4;
            double expected = 6;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test will validate the Subtract function
        /// </summary>
        [Fact]
        public void TestSubtract7And4()
        {
            // Arrange
            double a = 7;
            double b = 4;
            double expected = 3;
            var calc = new Calculator();

            // act
            double actual = calc.Subtract(a, b);

            // assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test will validate the Divide function
        /// </summary>
        [Fact]
        public void TestDivide10And5()
        {
            // Arrange
            double a = 10;
            double b = 5;
            double expected = 2;
            var calc = new Calculator();

            // act
            double actual = calc.Divide(a, b);

            // assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test will validate the Multiply function
        /// </summary>
        [Fact]
        public void TestMultiply4And8()
        {
            // Arrange
            double a = 4;
            double b = 8;
            double expected = 32;
            var calc = new Calculator();

            // act
            double actual = calc.Multiply(a, b);

            // assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test will validate the Mean function
        /// </summary>
        [Fact]
        public void TestMean()
        {
            // Arrange
            double[] nums = { 1.5, 2, 3, 10 };
            int size = 4;
            double expected = 4.125;
            var calc = new Calculator();

            // act
            double actual = calc.Mean(nums, size);

            // assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test will Validate the Median function for an even sized array
        /// </summary>
        [Fact]
        public void TestMedianEvenSize()
        {
            // Arrange
            double[] nums = { 1.5, 2, 3, 10 };
            int size = 4;
            double expected = 2.5;
            var calc = new Calculator();

            // act
            double actual = calc.Median(nums, size);

            // assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This test will Validate the Median function for an odd sized array
        /// </summary>
        [Fact]
        public void TestMedianOddSize()
        {
            // Arrange
            double[] nums = { 1.5, 2, 3, 10, 12 };
            int size = 5;
            double expected = 3;
            var calc = new Calculator();

            // act
            double actual = calc.Median(nums, size);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
