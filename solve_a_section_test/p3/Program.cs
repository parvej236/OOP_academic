using System;

abstract class Shape
{
    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        set { width = value >= 0 ? value : -value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value >= 0 ? value : -value; }
    }


    public abstract double Area();
    
    public virtual void Description()
    {
        Console.WriteLine($"Description: A shape with width {Width} and height {Height}");
    }
}

class Rectangle : Shape
{
    public override double Area()
    {
        return Width * Height;
    }

    public override void Description()
    {
        Console.WriteLine($"Description: A rectangle with width {Width} and height {Height}");
        Console.WriteLine($"Area: {Area()}");
    }
}

class Triangle : Shape
{
    public override double Area()
    {
        return 0.5 * Width * Height;
    }

    public override void Description()
    {
        Console.WriteLine($"Description: A triangle with width {Width} and height {Height}");
        Console.WriteLine($"Area: {Area()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[2];

        shapes[0] = new Rectangle { Width = 10.5, Height = 5 };
        shapes[1] = new Triangle { Width = 15, Height = 5 };

        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine($"Shape {i + 1}: {shapes[i]}");
            shapes[i].Description();
            Console.WriteLine();
        }
    }
}