using System;

class Vehicle
{
    private string model;
    private double rentalPrice;

    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }

    public double RentalPrice
    {
        get
        {
            return rentalPrice;
        }
        set
        {
            if (value >= 0)
            {
                rentalPrice = value;
            }
            else
            {
                rentalPrice = -value;
            }
        }
    }
    public virtual void Details()
    {
        Console.WriteLine("\nVehicle Details:");
        Console.WriteLine($"Model: {Model}\nRental Price: ${RentalPrice}");
    }
}

class Car : Vehicle
{
    public string FuelType { get; set; }

    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Fuel Type: {FuelType}");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();

        Console.Write("Enter model: ");
        car.Model = Console.ReadLine();

        Console.Write("Enter rental price: ");
        car.RentalPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter fuel type: ");
        car.FuelType = Console.ReadLine();

        car.Details();
        
    }
}