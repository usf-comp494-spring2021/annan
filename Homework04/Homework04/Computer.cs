/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/05/2021
/// Assignment:  Homework 4
/// Purpose:     This class library will show inheritance from parent to child classes.
/// </summary>

using System;

namespace Homework04
{
    /// <summary>
    /// This is the base parent class that holds attributes for all Computers
    /// </summary>
    public class Computer
    {
        public string Manufacture;
        public string Model;
        public string PurposeCode;
        public string CPUCode;

        /// <summary>
        /// Will produce a formatted output of all attributes in the class
        /// </summary>
        public virtual void WriteToConsole()
        {
            Console.WriteLine(
                format: "This is a Computer made by {0}.\n" +
                "The model is {1}, and is used as {2}.\n" +
                "The CPU is {3}.\n\n",
                Manufacture,
                Model,
                PurposeCode,
                CPUCode
            );
        }
    }
}
