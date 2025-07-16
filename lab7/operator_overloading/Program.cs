using System;

class Point
{
    public int x;
    public int y;


    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.x - p2.x, p1.y - p2.y);
    }

    public static Point operator *(Point p1, int scalar)
    {
        return new Point(p1.x * scalar, p1.y * scalar);
    }

    public static Point operator /(Point p1, int scalar)
    {
        if (scalar == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return new Point(p1.x / scalar, p1.y / scalar);
    }

    public static Point operator %(Point p1, int scalar)
    {
        if (scalar == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return new Point(p1.x % scalar, p1.y % scalar);
    }

    public static bool operator ==(Point p1, Point p2)
    {
        if (distance(10, p1) == distance(10, p2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }

    public static bool operator <(Point p1, Point p2)
    {
        return p1.x < p2.x && p1.y < p2.y;
    }

    public static bool operator >(Point p1, Point p2)
    {
        return !(p1 < p2);
    }

    public static bool operator >=(Point p1, Point p2)
    {
        return !(p1 < p2);
    }

    public static bool operator <=(Point p1, Point p2)
    {
        return !(p1 > p2);
    }

    public static Point operator ++(Point p)
    {
        return new Point(p.x + 1, p.y + 1);
    }

    public static Point operator --(Point p)
    {
        return new Point(p.x - 1, p.y - 1);
    }

    public static Point operator -(Point p)
    {
        return new Point(-p.x, -p.y);
    }

    public void show()
    {
        Console.WriteLine($"Point({x}, {y})");
    }

    public static int distance(int a, Point p2)
    {
        return (int)Math.Sqrt(Math.Pow(p2.x - a, 2) + Math.Pow(p2.y - a, 2));
    }
}


class Program
{
    static void Main(string[] args)
    {
        Point a = new Point(4, 2);
        Point b = new Point(3, 4);

        Console.WriteLine("\nArithmetic Operations:");

        Point c = a + b;
        Point d = a - b;
        Point e = a * 2;
        Point f = a / 2;
        Point g = a % 2;

        d.show();
        c.show();
        e.show();
        f.show();
        g.show();

        Console.WriteLine("\nLogical Operations:");

        bool isEqual = a == b;
        bool isNotEqual = a != b;
        bool isGreater = a > b;
        bool isLess = a < b;
        bool isGreaterOrEqual = a >= b;
        bool isLessOrEqual = a <= b;

        Console.WriteLine($"a == b: {isEqual}");
        Console.WriteLine($"a != b: {isNotEqual}");
        Console.WriteLine($"a > b: {isGreater}");
        Console.WriteLine($"a < b: {isLess}");
        Console.WriteLine($"a >= b: {isGreaterOrEqual}");
        Console.WriteLine($"a <= b: {isLessOrEqual}");

        Console.WriteLine("\nUnary Operators:");
        a++;
        b++;
        a.show();
        b.show();
        Console.WriteLine("\nUnary -:");
        a = -a;
        a.show();
    }
}