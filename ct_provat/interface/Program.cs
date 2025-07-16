using System;

// public abstract class Shape
// {
//     public abstract double Area();
// }

// public class Square : Shape
// {
//     int side;

//     public Square(int side)
//     {
//         this.side = side;
//     }

//     public override double Area()
//     {
//         return side * side;
//     }
// }


public interface IPrintable
{
    void Print();
    void Process();
}

public interface IScannable
{
    void Scan();
    void Process();
}

public class Document : IPrintable, IScannable
{
    void IPrintable.Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }

    void IPrintable.Process()
    {
        Console.WriteLine("Processing printable document...");
    }

    void IScannable.Process()
    {
        Console.WriteLine("Processing scannable document...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Square s1 = new Square(2);
        // Console.WriteLine("Area of square: " + s1.Area());

        Document doc = new Document();
        // doc.Print();
        doc.Scan();

        IPrintable printableDoc = doc;
        printableDoc.Print();
        printableDoc.Process();

        IScannable scannableDoc = doc;
        scannableDoc.Process();
    }
}