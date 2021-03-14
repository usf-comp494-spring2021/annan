/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/15/2021
/// Assignment:  Midterm
/// Purpose:     This test class will read in a file of numbers and use the CalculatorLib
///              to perform calculations
/// </summary>

using CalculatorLib;
using System;
using System.IO;

namespace MidtermProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a directory path, input file, and output file
            string dir = Environment.CurrentDirectory;
            string inputFile = "CalcInput.txt";
            string outputFile = "CalcOutput.txt";

            // Opening input file for reading numbers into an array
            Console.WriteLine($"Reading in numbers from {inputFile}");
            StreamReader textReader = File.OpenText(Path.Combine(dir, inputFile));
            double[] numArray = new double[100];
            int size = 0;
            for (; textReader.Peek() != -1; size++)
                numArray[size] = double.Parse(textReader.ReadLine());
            textReader.Close();

            // Sorting the array in ascending order
            Array.Sort(numArray, 0, size);

            // Calculating mean and median of the array
            Console.WriteLine("Doing calculations");
            var calc = new Calculator();
            double mean = calc.Mean(numArray, size);
            double median = calc.Median(numArray, size);

            // Creating the output file
            Console.WriteLine($"Writing out data to {outputFile}");
            StreamWriter textWriter = File.CreateText(Path.Combine(dir, outputFile));
            textWriter.WriteLine("These are the elements in the sorted array:");
            for (int i = 0; i < size; i++)
                textWriter.Write(numArray[i] + " ");
            textWriter.WriteLine($"\n\nThe mean of this list is {mean}.");
            textWriter.WriteLine($"The median of this list is {median}.");
            textWriter.Close();

            Console.WriteLine($"File was created in:\n{Path.GetFullPath(outputFile)}");
        }
    }
}
