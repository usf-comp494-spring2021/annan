/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        02/15/2021
/// Assignment:  Homework 3
/// Purpose:     This class library will perform basic calculations
/// </summary>

using System;

namespace CalculatorLib
{
    /// <summary>
    /// This class will maintain the necessary
    /// methods for calculator functionality.
    /// </summary>

    public class Calculator
    {
        /// <summary>
        /// This method will return the sum of A and B
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The sum of a and b</returns>
        public double Add(double a, double b)
        {
            return (a + b);
        }

        /// <summary>
        /// This method will return the difference of A and B
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The difference of a and b</returns>
        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        /// <summary>
        /// This method will return the quotient of A and B
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The quotient of a and b</returns>
        public double Divide(double a, double b)
        {
            return (a / b);
        }

        /// <summary>
        /// This method will return the product of A and B
        /// </summary>
        /// <param name="a">Value A</param>
        /// <param name="b">Value B</param>
        /// <returns>The product of a and b</returns>
        public double Multiply(double a, double b)
        {
            return (a * b);
        }
    }
}
