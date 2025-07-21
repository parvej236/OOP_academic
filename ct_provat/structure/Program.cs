using System;

class Rectangle
{
    public int width;
    public int height;
}

struct RectangleStruct
{
    public int width;
    public int height;

    public int Area()
    {
        return width * height;
    }
}

interface IShape
{
    int Area();
}

struct Square : IShape
{
    public int side;

    public int Area()
    {
        return side * side;
    }
}


struct Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static void Main(string[] args)
    {
        Point p1 = new Point(10, 20);
        Console.WriteLine("Point 1: " + p1.x + ", " + p1.y);

        Point p2 = p1; // Copying value type
        p2.x = 30; // Modifying p2 does not affect p1
        Console.WriteLine("Point 2: " + p2.x + ", " + p2.y); // p1 remains unchanged
        Console.WriteLine("Point 1 after modification: " + p1.x + ", " + p1.y);


        Rectangle r1 = new Rectangle();
        r1.width = 10;
        Console.WriteLine("Rectangle 1 width: " + r1.width);

        Rectangle r2 = r1; // Copying reference type
        r2.width = 20;
        Console.WriteLine("Rectangle 1 width: " + r1.width); // reference type
        Console.WriteLine("Rectangle 2 width: " + r2.width);

        RectangleStruct r3 = new RectangleStruct { width = 4, height = 5 };
        Console.WriteLine("Area of Rectangle 3: " + r3.Area());

        Square s1 = new Square { side = 5 };
        Console.WriteLine("Area of Square 1: " + s1.Area());

        Point[] points = new Point[3];
        points[0] = new Point {x =1, y=2};
        points[1] = new Point(3, 4);
        points[2] = new Point(5, 6);

        foreach (Point p in points)
        {
            Console.WriteLine("Point: " + p.x + ", " + p.y);
        }
    }
}
