using System;

class Employee
{
    private int ID;
    private string Name;

    public Employee(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }

    public virtual void DisplayInfo()
    {
        Console.Write($"ID: {ID}, Name: {Name}");
    }

    public virtual int CalculateBonus()
    {
        return 1000;
    }
}


class Manager : Employee
{
    private int TeamSize;

    public Manager(int ID, string Name, int TeamSize) : base(ID, Name)
    {
        this.TeamSize = TeamSize;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($", Team Size: {TeamSize}");
    }

    public override int CalculateBonus()
    {
        return 1000 + 200 * TeamSize;
    }
}

class Developer : Employee
{
    private string ProgrammingLanguage;

    public Developer(int ID, string Name, string ProgrammingLanguage) : base(ID, Name)
    {
        this.ProgrammingLanguage = ProgrammingLanguage;
    }

    public override void DisplayInfo()
    {

        base.DisplayInfo();
        Console.WriteLine($", Language: {ProgrammingLanguage}");
    }

    public override int CalculateBonus()
    {
        if (ProgrammingLanguage == "C#")
        {
            return 1000 + 500;
        }
        else
        {
            return 1000 + 300;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Manager(101, "M Parvej Alam", 5));
        employees.Add(new Manager(103, "Jotermoy Suttrodhor", 10));
        employees.Add(new Developer(201, "Lubon", "C#"));
        employees.Add(new Developer(210, "Jahid", "Java"));
        employees.Add(new Developer(211, "Priyom", "Python"));

        foreach (Employee employee in employees)
        {
            Console.Write($" [{employee}] ");
            employee.DisplayInfo();
            Console.WriteLine($"Bonus: ${employee.CalculateBonus()}\n");
        }
    }
}