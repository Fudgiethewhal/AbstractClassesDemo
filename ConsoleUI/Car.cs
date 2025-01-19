using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving");
        }
    }
}


