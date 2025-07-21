using System;
using System.Collections.Generic;
delegate void Calculator(int x, int y);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"{Name}, {Age} years old";
    }
}

class MyEvent
{
    // Declaere an event of type Action
    public event Action SomeEvent;
    // Method to raise the event
    public void RaiseEvent()
    {
        SomeEvent?.Invoke(); // Null check and invoke the event if not null
    }
}

class Program
{
    public static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public static void Mul(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    static void Main()
    {
        Calculator calc = new Calculator(Add);

        //multicast delegates
        calc += Mul;

        calc(20, 30);

        // anonymous delegate
        Calculator calcAdd = delegate (int a, int b)
        {
            Console.WriteLine(a + b);
        };

        calcAdd(5, 4);


        // Lambda Expressions - shorting
        List<int> nums = new List<int> { 5, 3, 8, 1, 2 };

        // ascending order
        nums.Sort((a, b) => a.CompareTo(b));
        nums.ForEach(num => Console.Write(num + ", "));
        Console.WriteLine();

        // descending sort
        nums.Sort((a, b) => b.CompareTo(a));
        nums.ForEach(num => Console.Write(num + ", "));
        Console.WriteLine();

        // sorting with objects list
        List<Person> people = new List<Person>
        {
            new Person{Name = "Alice", Age= 30},
            new Person{Name = "Parvej", Age = 22},
            new Person{Name = "Rahim", Age = 13}
        };

        people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
        people.ForEach(person => Console.WriteLine(person));

        MyEvent evt = new MyEvent();
        // subscribe to the event using a lambda expression
        evt.SomeEvent += () => Console.WriteLine("Event triggered");
        // trigger the event
        evt.RaiseEvent();

    }
}