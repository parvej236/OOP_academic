using System;

class Complex
{
    int i;
    int r;

    public Complex(int r, int i)
    {
        this.r = r;
        this.i = i;
    }

    public int R
    {
        get { return r; }
        set { r = value; }
    }

    public int I
    {
        get { return i; }
        set { i = value; }
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.r + c2.r, c1.i + c2.i);
    }

    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.r - c2.r, c1.i - c2.i);
    }

    public static Complex operator *(Complex c1, Complex c2)
    {
        return new Complex(
            c1.r * c2.r - c1.i * c2.i,
            c1.r * c2.i + c1.i * c2.r
        );
    }

    public static bool operator ==(Complex c1, Complex c2)
    {
        return c1.r == c2.r && c1.i == c2.i;
    }

    public static bool operator !=(Complex c1, Complex c2)
    {
        return !(c1 == c2);
    }

    public void Display()
    {
        Console.WriteLine($"{r} + {i}i");
    }

    public int Absolute()
    {
        return (int)Math.Sqrt(r * r + i * i);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex(3, 4);
        Console.WriteLine("Absolute value of c1: " + c1.Absolute());

        Complex c2 = new Complex(1, 2);
        Console.WriteLine("Absolute value of c2: " + c2.Absolute());

        Complex add = c1 + c2;
        add.Display();

        Complex sub = c1 - c2;
        sub.Display();

        Complex mul = c1 * c2;
        mul.Display();

        if (c1 == c2)
        {
            Console.WriteLine("c1 is equal to c2");
        }
        else
        {
            Console.WriteLine("c1 is not equal to c2");
        }
    }
}