using System;

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Counter
{
    public int n;

    public Counter(int n)
    {
        this.n = n;
    }

    public static Counter operator ++(Counter cnt)
    {
        return new Counter(cnt.n + 1);
    }

    public void Show()
    {
        Console.WriteLine($"n : {n}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myPig = new Pig();
        Animal myDog = new Dog();

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();

        // deferences pre vs post increment by operator overloading
        Counter cnt1 = new Counter(5);
        Counter cnt2 = cnt1++;
        cnt2.Show();
        Counter cnt3 = ++cnt1;
        cnt3.Show();

    }
}