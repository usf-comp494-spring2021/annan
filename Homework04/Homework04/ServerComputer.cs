/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/05/2021
/// Assignment:  Homework 4
/// Purpose:     This class library will ...
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    public class ServerComputer:Computer
    {
        public int CPUCount;

        //public ServerComputer()
        //{

        //}

        //~ServerComputer() // Finalizer
        //{
        //    // deallocating any unmanaged resources
        //}

        public override void WriteToConsole()
        {
            Console.WriteLine(
                format: "{0} {1} {2} {3} {4}\n\n",
                Manufacture,
                Model,
                PurposeCode,
                CPUCode,
                CPUCount
            );
        }
    }
}
