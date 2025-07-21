using System;

// name hiding
// class A
// {
//     public int i;

//     public void show()
//     {
//         Console.WriteLine("i in base class: " + i);
//     }
// }

// class B : A
// {
//     new int i; // this is hides the i in A
//     public B(int a, int b)
//     {
//         base.i = a;
//         i = b;
//     }

//     new public void show()
//     {
//         base.show();
//         Console.WriteLine("i in derived class: " + i);
//     }
// }

// Order of constructor calling

class A
{
    public A()
    {
        Console.WriteLine("Constructing A...");
    }
}

class B : A
{
    public B()
    {
        Console.WriteLine("Constructing B...");
    }
}

class C : B
{
    public C()
    {
        Console.WriteLine("Constructing C...");
    }
}

// Referencing
class X
{
    public int a;
    public X(int a)
    {
        this.a = a;
    }
}

class Y : X
{
    public int b;
    public Y(int a, int b) : base(a)
    {
        this.b = b;
    }
}

class Program
{
    static void Main()
    {
        // B b = new B(2,3);
        // b.show();

        C c = new C();

        X x1 = new X(10);
        X x2;
        Y y = new Y(5, 8);
        x2 = x1;
        Console.WriteLine("x2.a: " + x2.a);
        x2 = y;
        Console.WriteLine("x2.a: " + x2.a);
    }
}
