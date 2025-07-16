using System;

public class MyClass
{
    // property
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 1)
            {
                Console.WriteLine("Age cannot be less than zero");
            }
            else
            {
                age = value;
            }
        }
    }

    private string name;

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.Age = 25;
        Console.WriteLine("Age: " + obj.Age);

        obj.Age = -5; // This will trigger the validation
        Console.WriteLine("Age: " + obj.Age);
    }
}