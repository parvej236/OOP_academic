using System;

class Person
{
    public string Name { get; set; }
    public string ID { get; set; }

    public Person(string Name, string ID)
    {
        this.Name = Name;
        this.ID = ID;
    }
    public virtual void Display()
    {
        Console.WriteLine($"Name: {Name}\nID: {ID}");
    }

}

class Employee : Person
{
    private double salary;
    public double Salary
    {
        get { return salary; }
       set { salary = value >= 0 ? value : -value; }
    }

    public Employee(string Name, string ID, double salary) : base(Name, ID)
    {
        this.salary = salary;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Salary: ${salary}");
    }
}

class Manager : Employee
{
    public double Bonus { get; set; }

    public Manager(string Name, string ID, double salary, double Bonus) : base(Name, ID, salary)
    {
        this.Bonus = Bonus;
    }
    public override void Display()
    {
        Console.WriteLine("\nManager Details:");
        base.Display();
        Console.WriteLine($"Bonus: ${Bonus}\nTotal Compensation:${Salary + Bonus}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string Name = Console.ReadLine();

        Console.Write("Enter ID: ");
        string ID = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double Salary = double.Parse(Console.ReadLine());

        Console.Write("Enter Bonus: ");
        double Bonus = double.Parse(Console.ReadLine());

        Manager manager = new Manager(Name, ID, Salary, Bonus);
        manager.Display();
    }
}