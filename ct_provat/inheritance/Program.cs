using System;

class TwoDShape
{
    double height;
    double width;
    public double Height
    {
        get { return height; }
        set
        {
            height = value < 0 ? -value : value;
        }
    }

    public double Width
    {
        get { return width; }
        set
        {
            width = value < 0 ? -value : value;
        }
    }

    public void ShowDim()
    {
        Console.WriteLine($"Width: {width}, Height: {Height}");
    }
}

class Triangle : TwoDShape
{
    public string Style;
    public double Area()
    {
        return Width * Height / 2;
    }

    public void ShowStyle()
    {
        Console.WriteLine($"Triangle is: {Style}");
    }
}

class B
{
    protected int i, j;
    public void Set(int a, int b)
    {
        i = a;
        j = b;
    }

    public void Show()
    {
        Console.WriteLine(i + ", " + j);
    }
}

class D : B
{
    int k;
    public void Setk()
    {
        k = i * j;
    }

    public void showk()
    {
        Console.WriteLine(k);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle();

        t1.Width = 4;
        t1.Height = 5;
        t1.Style = "isosceles";

        Console.WriteLine("infor for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is: " + t1.Area());

        D d = new D();
        d.Set(2, 3);
        d.Show();
        d.Setk();
        d.showk();

    }
}