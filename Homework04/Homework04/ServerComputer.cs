/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/05/2021
/// Assignment:  Homework 4
/// Purpose:     This class library will show inheritance from parent to child classes.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    /// <summary>
    /// This is a child class of Computer that has an additional attribute of CPUCount
    /// </summary>
    public class ServerComputer:Computer
    {
        public int CPUCount;

        /// <summary>
        /// Will produce a formatted output of all attributes in the class
        /// </summary>
        public override void WriteToConsole()
        {
            Console.WriteLine(
                format: "This is a Server Computer made by {0}.\n" +
                "The model is {1}, and is used as {2}.\n" +
                "The CPU is {3}, and there are {4} CPUs.\n\n",
                Manufacture,
                Model,
                PurposeCode,
                CPUCode,
                CPUCount
            );
        }
    }
}
