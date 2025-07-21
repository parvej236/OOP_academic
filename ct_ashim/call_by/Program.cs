using System;

class RefTest
{
    // method to square an integer using ref parameter
    public void Sqr(ref int i)
    {
        i = i * i;
    }

    // method to swap two integers using ref parameters
    public void Swap(ref int a, ref int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
    }

    // Method that has two retrun values using out parameter
    public int GetParts(double n, out double frac)
    {
        int whole;
        whole = (int)n;
        frac = n - whole;
        return whole;
    }

    // take custom argumetns with params
    public int MinVal(params int[] nums)
    {
        int m;
        if (nums.Length == 0)
        {
            Console.WriteLine("Error: no arguments provided");
            return 0;
        }
        m = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < m)
            {
                m = nums[i];
            }
        }
        return m;
    }

    public void ShowArgs(string msg, params int[] nums)
    {
        Console.WriteLine(msg + ": ");
        foreach (int i in nums)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        Console.WriteLine("Before: " + x);

        RefTest rt = new RefTest();
        rt.Sqr(ref x);



        Console.WriteLine("After: " + x);

        int a = 10, b = 20;
        Console.WriteLine("Before Swap: a = " + a + ", b = " + b);
        rt.Swap(ref a, ref b);
        Console.WriteLine("After Swap: a = " + a + ", b = " + b);

        int i;
        double f;
        i = rt.GetParts(10.75, out f);
        Console.WriteLine("Integer part: " + i + ", Fractional part: " + f);

        int min;
        min = rt.MinVal(10, 20, 5, 15);
        Console.WriteLine("Minimum is: " + min);

        min = rt.MinVal(a, b, -1);
        Console.WriteLine("Mininum is: " + min);

        int[] arr = { 1, 2, 3, 4, 5 };
        min = rt.MinVal(arr);
        Console.WriteLine("Mininum is: " + min);

        rt.ShowArgs("Here are some integers", 1, 3, 3, 4, 5);
        rt.ShowArgs("Here are two more", 29, 123);

        // object initializer
        MyClass obj = new MyClass { Count = 100, Str = "Testing" };
        Console.WriteLine(obj.Count + ", " + obj.Str);

        // pass references to methos
        Demo demo1 = new Demo(4, 5);
        Demo demo2 = new Demo(6, 7);
        demo1.Show();
        demo2.Show();

        if (demo1.SameAs(demo2))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Not equal");
        }

        demo1.Copy(demo2);
        demo1.Show();
        demo2.Show();
    }
}

class MyClass
{
    public int Count;
    public string Str;
}

class Demo
{
    int alpha, beta;
    public Demo(int i, int j)
    {
        alpha = i;
        beta = j;
    }

    public bool SameAs(Demo demo)
    {
        return (demo.alpha == alpha) & (demo.beta == beta);
    }

    public void Copy(Demo demo)
    {
        alpha = demo.alpha;
        beta = demo.beta;
    }

    public void Show()
    {
        Console.WriteLine($"alpha: {alpha}, beta: {beta}");
    }
}