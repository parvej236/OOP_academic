using System;

class MyException : Exception
{
    public MyException(string message) : base(message)
    {
    }
}

public class DivideByOddNumberException : Exception
{
    public DivideByOddNumberException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {

        // Example of system exception
        try
        {
            int n;
            n = -2;
            if (n < 0)
            {
                throw new SystemException("Negative number not allowed");
            }
        }
        catch (SystemException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        // Example of IndexOutOfRangeException
        try
        {
            int[] arr = new int[5];
            arr[10] = 100; // This will throw an IndexOutOfRangeException

        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Example of DivideByZeroException
        try
        {
            int a = 10;
            int b = a / 0; // This will throw a DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
            Console.WriteLine("Source: " + ex.Source);
        }

        // Example of ArgumentOutOfRangeException
        try
        {
            int n = -3;
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("n", "Value cannot be negative");
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // NullReference Exception Example
        try
        {
            string str = null;
            Console.WriteLine(str.Length); // This will throw a NullReferenceException
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Example of custom exception
        try
        {
            int age = -1;
            if (age < 0)
            {
                throw new MyException("Age cannot be negative");
            }
        }
        catch (MyException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }


        // Example of DivideByOddNumberException
        try
        {
            int divisor = 3; // Odd number
            if (divisor % 2 == 1)
            {
                throw new DivideByOddNumberException("Cannot divide by an odd number: " + divisor);
            }
            Console.WriteLine("Result: " + 10 / divisor);
        }
        catch (DivideByOddNumberException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }

        // Example of Nested try-catch blocks with re-throwing
        Console.WriteLine("Nested try-catch example:");
        try
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Inner Catch: " + ex.Message);
                throw; // Re-throwing the exception to outer catch
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Outer Catch: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed after nested try-catch.");
        }

        // rethrowing example
        Console.WriteLine("Rethrowing example:");
        try
        {
            MethodA();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught in Main: " + ex.Message);
        }
    }

    public static void MethodA()
    {
        try
        {
            MethodB();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught in MethodA. Rethrowing...");
            throw; // Rethrowing the exception
        }
    }

    public static void MethodB()
    {
        throw new IndexOutOfRangeException("An error occurred in MethodB.");
    }
}