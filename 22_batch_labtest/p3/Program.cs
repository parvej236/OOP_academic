using System;
using System.Collections.Generic;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public int Age { get; set; }

    public Dog(int age)
    {
        Age = age;
    }

    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }

    public static int operator +(Dog d1, Dog d2)
    {
        return d1.Age + d2.Age;
    }
}

class Bulldog : Dog
{
    public Bulldog(int age) : base(age)
    {

    }
    public override void Speak()
    {
        Console.WriteLine("The bulldog growls.");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Dog[] dogs = new Dog[]
        {
            new Dog(4),
            new Bulldog(6),
            new Dog(3),
            new Bulldog(5)
        };

        foreach (Dog d in dogs)
        {
            d.Speak();
        }

        int totalAge = dogs[0] + dogs[1];
        Console.WriteLine($"Total age is: {totalAge}");

    }
}