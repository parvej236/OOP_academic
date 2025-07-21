using System;

class CUET
{
    public int ID;
    public string Name;
    public string Department;

    public CUET(int ID, string Name, string Department)
    {
        this.ID = ID;
        this.Name = Name;
        this.Department = Department;
    }

    public virtual void DisplayInfo()
    {
        Console.Write($"Name: {Name}, Department: {Department}, ID: {ID}, ");
    }
}

class CSE : CUET
{
    public int Batch;
    public string Section;
    public string Group;

    public CSE(int ID, string Name, string Department, int Batch, string Section, string Group) : base(ID, Name, Department)
    {
        this.Batch = Batch;
        this.Section = Section;
        this.Group = Group;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Batch: {Batch}, Section: {Section}, Group: {Group}");
    }
}

class EEE : CUET
{
    public int Batch;
    public string Section;
    public string Group;

    public EEE(int ID, string Name, string Department, int Batch, string Section, string Group) : base(ID, Name, Department)
    {
        this.Batch = Batch;
        this.Section = Section;
        this.Group = Group;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Batch: {Batch}, Section: {Section}, Group: {Group}");
    }
}

class ME : CUET
{
    public int Batch;
    public string Section;
    public string Group;

    public ME(int ID, string Name, string Department, int Batch, string Section, string Group) : base(ID, Name, Department)
    {
        this.Batch = Batch;
        this.Section = Section;
        this.Group = Group;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Batch: {Batch}, Section: {Section}, Group: {Group}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<CUET> students = new List<CUET>();

        students.Add(new CSE(1, "Prantik", "CSE", 2021, "A", "A1"));
        students.Add(new CSE(2, "Parvej Alam", "CSE", 2023, "A", "B1"));

        students.Add(new EEE(3, "Bob", "EEE", 2023, "B", "A1"));
        students.Add(new EEE(4, "Charlie", "EEE", 2022, "B", "A2"));

        students.Add(new ME(5, "David", "ME", 2023, "C", "B2"));
        students.Add(new ME(6, "Eve", "ME", 2022, "C", "A1"));

        foreach (CUET student in students)
        {
            student.DisplayInfo();
        }
    }
}