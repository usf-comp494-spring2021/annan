/// <summary>
/// Language:    C#
/// Author:      Anna Nguyen
/// Course:      COMP494 - C#
/// Date:        03/05/2021
/// Assignment:  Homework 4
/// Purpose:     This program tests the class library of computers to show inheritance
///              was properly implemented.
/// </summary>

using Homework04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04Program
{
    /// <summary>
    /// This program tests the class library of computers to show inheritance.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Computer testComputer = new Computer();
            testComputer.Manufacture = "HP";
            testComputer.Model = "EliteDesk 800 G1";
            testComputer.PurposeCode = "Personal Computer Workstation";
            testComputer.CPUCode = "Intel i5 Quad Core";
            testComputer.WriteToConsole();

            LaptopComputer testLaptopComputer = new LaptopComputer();
            testLaptopComputer.Manufacture = "ASUS";
            testLaptopComputer.Model = "ROG Flow X13 GV301";
            testLaptopComputer.PurposeCode = "Gaming Laptop";
            testLaptopComputer.CPUCode = "AMD Ryzen 9 5000 Series";
            testLaptopComputer.ScreenSize = 13.4;
            testLaptopComputer.WriteToConsole();

            ServerComputer testServerComputer = new ServerComputer();
            testServerComputer.Manufacture = "Lenovo";
            testServerComputer.Model = "ThinkSystem ST550";
            testServerComputer.PurposeCode = "Tower Servers";
            testServerComputer.CPUCode = "Xeon Bronze";
            testServerComputer.CPUCount = 6;
            testServerComputer.WriteToConsole();
        }
    }
}
