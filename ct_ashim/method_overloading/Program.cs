using System;

class Program
{
    // overloading (complile time polymorphism)
    // a) method overloading
    void totalSum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("The total sum is: " + sum);
    }

    void totalSum(double a, double b)
    {
        double sum = a + b;
        Console.WriteLine("The total sum is: " + sum);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.totalSum(5, 10);          // Calls the int version
        program.totalSum(5.7, 10.5);      // Calls the double version

        // b) operator overloading
        int x = 7;
        int y = 3;
        int result = x + y; // Uses built-in operator overloading for integers
        Console.WriteLine("The result of x + y is: " + result);

        string str1 = "Hello, ";
        string str2 = "World!";
        string strResult = str1 + str2; // Uses built-in operator overloading for strings
        Console.WriteLine("The result of str1 + str2 is: " + strResult);
    }
}