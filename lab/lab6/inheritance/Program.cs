using System;

class Animal
{
    public virtual void speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Tiger : Animal
{
    public override void speak()
    {
        Console.WriteLine("Tiger speaks");
    }
}

class Dog : Animal
{
    public override void speak()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        Tiger tiger = new Tiger();
        Dog dog = new Dog();

        animal.speak(); // Output: Animal speaks
        tiger.speak();  // Output: Tiger speaks
        dog.speak();    // Output: Dog barks

        Animal animalTiger = new Tiger();
        Animal animalDog = new Dog();
        animalTiger.speak(); // Output: Tiger speaks
        animalDog.speak();   // Output: Dog barks

        List<Animal> animals = new List<Animal>();

        for (int i = 0; i < 5; i++)
        {
            animals.Add(new Dog());
            animals.Add(new Tiger());
        }


        foreach (Animal a in animals)
        {
            a.speak();
        }

        Console.WriteLine("List of Tigers and Dogs");

        List<Tiger> tigers = new List<Tiger>();
        List<Dog> dogs = new List<Dog>();

        for (int i = 0; i < 10; i++)
        {
            tigers.Add(new Tiger());
            dogs.Add(new Dog());
        }

        // foreach (Tiger t in tigers)
        // {
        //     t.speak();
        // }
                

        for (int i = 0; i < tigers.Count; i++)
        {
            tigers[i].speak();
            dogs[i].speak();
        }


    }
}