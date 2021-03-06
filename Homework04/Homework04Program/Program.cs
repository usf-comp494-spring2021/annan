using Homework04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer testComputer1 = new Computer();
            LaptopComputer testLaptopComputer1 = new LaptopComputer();
            ServerComputer testServerComputer1 = new ServerComputer();

            testComputer1.Manufacture = "Dell";
            testComputer1.Model = "D2021";
            testComputer1.PurposeCode = "Compute";
            testComputer1.CPUCode = "010101010";
            testComputer1.WriteToConsole();

            testLaptopComputer1.Manufacture = "Dell";
            testLaptopComputer1.Model = "D2021";
            testLaptopComputer1.PurposeCode = "Compute";
            testLaptopComputer1.CPUCode = "010101010";
            testLaptopComputer1.ScreenSize = 15;
            testLaptopComputer1.WriteToConsole();

            testServerComputer1.Manufacture = "Dell";
            testServerComputer1.Model = "D2021";
            testServerComputer1.PurposeCode = "Compute";
            testServerComputer1.CPUCode = "010101010";
            testServerComputer1.CPUCount = 8;
            testServerComputer1.WriteToConsole();
        }
    }
}
