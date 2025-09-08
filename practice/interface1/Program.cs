using System;

interface IShape
{
    int Area();
    void Display();
}

class Rectangle : IShape
{
    private int Width;
    private int Height;
    public Rectangle(int w, int h)
    {
        Width = w;
        Height = h;
    }

    public int Area() {
        return Width*Height;
    }

    public void Display(){
        Console.WriteLine($"Rectangle: Width={Width}, Height={Height}, Area={Area()} ");
    }
}

class Square : IShape
{
    private int Side;
    public Square(int side)
    {
        Side = side;
    }

    public int Area(){
        return Side*Side;
    }

    public void Display(){
        Console.WriteLine($"Square: Side={Side}, Area={Area()}");
    }
}

class Circle : IShape
{
    private int Radius;
    public Circle(int r)
    {
        Radius = r;
    }

    public int Area()
    {
        return (int) (3.1416*Radius*Radius);
    }

    public void Display()
    {
        Console.WriteLine($"Circle: Side={Radius}, Area={Area()}");
    }

}

class Test
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5,10);
        Square square = new Square(4);
        Circle circle = new Circle(3);

        IShape[] shapes = { rectangle, square, circle};

        foreach (IShape shape in shapes)
        {
            shape.Display();
        }
    }
}