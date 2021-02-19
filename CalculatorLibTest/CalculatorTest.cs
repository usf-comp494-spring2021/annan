/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        02/15/2021
/// Assignment:  Homework 3
/// Purpose:     This test class will show that the functions in the
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
        public void TestAdding2And4()
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
        public void TestSubtracting7And4()
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
        public void TestDividing10And5()
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
        public void TestMultiplying4And8()
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
    }
}
