using System;

interface IEmployee
{
    void Work();
    string GetInfo();
}

interface IManager
{
    void Work();
    void ManageTeam();
    string GetInfo();
}

class TeamLead : IEmployee, IManager
{
    private string Name;
    private int TeamSize;

    void IEmployee.Work()
    {
        Console.WriteLine($"Teamlead {Name} is coding and reviewing.");
    }

     void IManager.Work()
    {
        Console.WriteLine($"Teamlead {Name} is managing and planning.");
    }

    string IEmployee.GetInfo()
    {
        return $"Employee: {Name}";
    }

    string IManager.GetInfo()
    {
        return $"Manager: {Name}, TeamSize: {TeamSize}";
    }

    public void ManageTeam()
    {
        Console.WriteLine($"TeamLead {Name} is managing {TeamSize} developers.");
    }

    public TeamLead(string name, int size)
    {
        Name = name;
        TeamSize = size;
    }
}

class Test
{
    static void Main(string[] args)
    {
        TeamLead teamLead = new TeamLead("John", 5);
        IEmployee emp = teamLead;
        IManager mgr = teamLead;

        emp.Work();
        mgr.Work();

        Console.WriteLine(emp.GetInfo());
        Console.WriteLine(mgr.GetInfo());

        teamLead.ManageTeam();



    }
}