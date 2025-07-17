using System;

class Complex
{
    private double real;
    private double img;

    public Complex()
    {
        real = 0;
        img = 0;
    }

    public Complex(double real, double img)
    {
        this.real = real;
        this.img = img;
    }

    public void display()
    {
        Console.WriteLine($"Complex: {real}+{img}i");
    }

    public Complex add(Complex c)
    {
        return new Complex(this.real + c.real, this.img + c.img);
    }
    public Complex subtract(Complex c)
    {
        return new Complex(this.real - c.real, this.img - c.img);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Complex c1 = new Complex(3, 4);
        Complex c2 = new Complex(1, 2);

        Console.WriteLine("Complex Number 1:");
        c1.display();

        Console.WriteLine("Complex Number 2:");
        c2.display();

        Complex sum = c1.add(c2);
        Console.WriteLine("Sum:");
        sum.display();

        Complex difference = c1.subtract(c2);
        Console.WriteLine("Difference:");
        difference.display();
    }
}