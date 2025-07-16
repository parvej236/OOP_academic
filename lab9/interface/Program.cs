using System;

public interface IWorker
{
    void work(); 
}

public interface ILeader
{
    void lead();
}

public class Employee : IWorker, ILeader
{
    public void work()
    {
        Console.WriteLine("Working...");
    }

    public void lead()
    {
        Console.WriteLine("Leading...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.work();
        employee.lead();
    }
}