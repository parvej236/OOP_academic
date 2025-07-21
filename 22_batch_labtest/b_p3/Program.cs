using System;

class Vehicle
{
	public virtual void Start()
	{
		Console.WriteLine("The vehicle starts.");
	}
}

class Car : Vehicle
{
	public int Battery { get; set; }
	
	public Car(int battery)
	{
		Battery = battery;
	}
	
	public override void Start()
	{
		Console.WriteLine("The car starts");
	}
	
}

class ElectricCar : Car
{
    public ElectricCar(int battery) : base(battery)
    {
    }
    public override void Start()
    {
        Console.WriteLine("The electric car starts silently");
    }

    public static bool operator ==(ElectricCar e1, ElectricCar e2)
    {
        return e1.Battery == e2.Battery;
    }

    public static bool operator !=(ElectricCar e1, ElectricCar e2)
    {
        return !(e1 == e2);
    }
}

class Program
{
	static void Main(string[] args)
	{
		Car[] cars = new Car[]
		{
			new Car(15),
			new ElectricCar(12),
			new Car(10),
			new ElectricCar(5)
		};
		
		foreach(Car c in cars)
		{
			c.Start();
		}

        ElectricCar e1 = new ElectricCar(12);
        ElectricCar e2 = new ElectricCar(12);
		
		if (e1 == e2)
        {
            Console.WriteLine("The battery is equal");
        }
        else
        {
            Console.WriteLine("The battery is not equal");
        }
		
	}
}
			