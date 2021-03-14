/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/15/2021
/// Assignment:  Midterm
/// Purpose:     Adapted from Homework 3. This class library will perform basic calculations
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

        /// <summary>
        /// This method will return the mean the array of numbers
        /// </summary>
        /// <param name="nums">Array of numbers</param>
        /// <param name="size">The size of the array</param>
        /// <returns>The mean of the array of numbers</returns>
        public double Mean(double[] nums, int size)
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum += nums[i];
            return (sum / size);
        }

        /// <summary>
        /// This method will return the median the array of numbers
        /// </summary>
        /// <param name="nums">A sorted array of numbers</param>
        /// <param name="size">The size of the array</param>
        /// <returns>The median of the array of numbers</returns>
        public double Median(double[] nums, int size)
        {
            double median;
            // even sized array
            if (size % 2 == 0)
            {
                median = (nums[size / 2] + nums[(size / 2) - 1]) / 2;
            }
            // odd sized array
            else
                median = nums[size / 2];
            return median;
        }
    }
}