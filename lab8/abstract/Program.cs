// abstract class er object banano jay na
// method virtual thakle override kora mendatory na
// abstract method obossoi ekta abstract class er moddhe hbe
// it is possible to create normal method in an abstract class

using System;

abstract class Shape
{
    public abstract double area();

    public virtual void display()
    {
        Console.WriteLine("This is a shape");
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double area()
    {
        return Math.Round(Math.PI * radius * radius, 2);
    }

    public override void display()
    {
        Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double area()
    {
        return length * width;
    }

    public override void display()
    {
        Console.WriteLine("This is a rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape s = new Circle(5);
        Console.WriteLine("Area of the circle: " + s.area());
        Console.WriteLine("Shape type: " + s);
        s.display();

        Rectangle r = new Rectangle(4, 5);
        Console.WriteLine("\nArea of the rectangle: " + r.area());
        Console.WriteLine("Shape type: " + r);
        r.display();
    }
}