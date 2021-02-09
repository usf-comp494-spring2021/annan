/**
 * Language:    C#
 * Author:      Anna Nguyen
 * Course:      COMP494 - C#
 * Date:        02/08/2021
 * Assignment:  Homework #2
 * Purpose:     Take an array of numbers, loop through the array and output
 *              the number and state if the number is even or odd
 */
using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 5, 11, 99, 4, 17, 38, 76, 101 };

            for(int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0) // divisible by 2
                    Console.WriteLine(numbers[i] + " is even.");
                else // remainder 1
                    Console.WriteLine(numbers[i] + " is odd.");
            }
        }
    }
}
