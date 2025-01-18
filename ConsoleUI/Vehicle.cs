using System;

namespace ConsoleUI;

internal abstract class Vehicle
{
    public string Year { get; set; } = "Default value";
    public string Make { get; set; } = "Default value";
    public string Model { get; set; } = "Default value";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Default Virtual Drive Method");
    }
}