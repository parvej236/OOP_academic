using System;

class Animal // Base class (parent)
{
    public virtual void animalSound()  // Mark as virtual so it can be overridden
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal // Derived class (child)
{
    public override void animalSound()  // Override the base method
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal // Derived class (child)
{
    public override void animalSound()  // Override the base method
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); // Create an Animal object
        Animal myPig = new Pig();       // Create a Pig object
        Animal myDog = new Dog();       // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}
