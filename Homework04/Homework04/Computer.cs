/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/05/2021
/// Assignment:  Homework 4
/// Purpose:     This class library will ...
/// </summary>

using System;

namespace Homework04
{
    public class Computer
    {
        public string Manufacture;
        public string Model;
        public string PurposeCode;
        public string CPUCode;

        //public Computer()
        //{
        //    Manufacture = "";
        //    Model = "";
        //    PurposeCode = "";
        //    CPUCode = "";
        //}

        //public Computer(string newManufacture, string newModel, string newPurposeCode, string newCPUCode)
        //{
        //    Manufacture = newManufacture;
        //    Model = newModel;
        //    PurposeCode = newPurposeCode;
        //    CPUCode = newCPUCode;
        //}

        //~Computer() // Finalizer
        //{
        //    // deallocating any unmanaged resources
        //}

        public virtual void WriteToConsole()
        {
            Console.WriteLine(
                format: "{0} {1} {2} {3}\n\n",
                Manufacture,
                Model,
                PurposeCode,
                CPUCode
            );
        }
    }
}
