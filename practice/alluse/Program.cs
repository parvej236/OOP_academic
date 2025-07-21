using System;
using System.Collections.Generic;

// 1. Interface IMachine
interface IMachine
{
    void Start();
    void Stop();
}

// 2. Interface IMaintainable
interface IMaintainable
{
    void PerformMaintenance();
}

// Extra interface for Drone
interface IRechargeable
{
    void RechargeBattery();
    int CheckBatteryLevel();
}

// 3. Abstract class Machine implementing IMachine
abstract class Machine : IMachine
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public abstract void Start();
    public abstract void Stop();

    public void GetInfo()
    {
        Console.WriteLine($"Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}");
    }
}

// 4a. Robot class inherits Machine, implements Start and Stop
class Robot : Machine
{
    public override void Start()
    {
        Console.WriteLine("Robot is starting up with calibration...");
    }

    public override void Stop()
    {
        Console.WriteLine("Robot is shutting down and entering standby mode.");
    }
}

// 4b. Vehicle class inherits Machine, implements IMaintainable
class Vehicle : Machine, IMaintainable
{
    public override void Start()
    {
        Console.WriteLine("Vehicle engine starting...");
    }

    public override void Stop()
    {
        Console.WriteLine("Vehicle engine stopping...");
    }

    public void PerformMaintenance()
    {
        Console.WriteLine("Performing vehicle maintenance: checking tires, oil, and brakes.");
    }
}

// 5. Drone class inherits Machine, implements IMaintainable and IRechargeable
class Drone : Machine, IMaintainable, IRechargeable
{
    private int batteryLevel;

    public Drone()
    {
        batteryLevel = 100; // battery full initially
    }

    public override void Start()
    {
        Console.WriteLine("Drone propellers spinning up...");
    }

    public override void Stop()
    {
        Console.WriteLine("Drone landing and powering down...");
    }

    public void PerformMaintenance()
    {
        Console.WriteLine("Performing drone maintenance: cleaning sensors and checking rotors.");
    }

    public void RechargeBattery()
    {
        Console.WriteLine("Recharging drone battery...");
        batteryLevel = 100;
    }

    public int CheckBatteryLevel()
    {
        return batteryLevel;
    }

    // Simulate battery drain for demo purposes
    public void Fly()
    {
        if (batteryLevel > 0)
        {
            Console.WriteLine("Drone is flying...");
            batteryLevel -= 20;
        }
        else
        {
            Console.WriteLine("Battery empty! Please recharge.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create instances
        Robot robot = new Robot { Manufacturer = "RoboCorp", Model = "RX9000", Year = 2025 };
        Vehicle vehicle = new Vehicle { Manufacturer = "AutoMakers", Model = "Speedster", Year = 2020 };
        Drone drone = new Drone { Manufacturer = "FlyHigh", Model = "D-200", Year = 2023 };

        // Call methods individually
        robot.GetInfo();
        robot.Start();
        robot.Stop();
        Console.WriteLine();

        vehicle.GetInfo();
        vehicle.Start();
        vehicle.PerformMaintenance();
        vehicle.Stop();
        Console.WriteLine();

        drone.GetInfo();
        drone.Start();
        drone.Fly();
        Console.WriteLine($"Battery level: {drone.CheckBatteryLevel()}%");
        drone.PerformMaintenance();
        drone.RechargeBattery();
        Console.WriteLine($"Battery level after recharge: {drone.CheckBatteryLevel()}%");
        drone.Stop();
        Console.WriteLine();

        // Polymorphism: use collection of IMachine
        List<IMachine> machines = new List<IMachine>();
        machines.Add(robot);
        machines.Add(vehicle);
        machines.Add(drone);
        
        Console.WriteLine("Starting all machines polymorphically:");
        foreach (var machine in machines)
        {
            machine.Start();
        }
        Console.WriteLine();

        Console.WriteLine("Stopping all machines polymorphically:");
        foreach (var machine in machines)
        {
            machine.Stop();
        }
    }
}
