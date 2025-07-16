using System;

public class MyOopException : Exception
{
    public MyOopException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args) {

        // Example of try-catch-finally with IndexOutOfRangeException
        // try
        // {
        //     int[] ara = {1,2,3};
        //     Console.WriteLine(ara[5]);
        // }
        // catch (IndexOutOfRangeException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Program Executed");
        // }

        // Example of try-catch-finally with DivideByZeroException
        // try
        // {
        //     int a = 10;
        //     int b = a/0;
        //     Console.WriteLine("Result: " + b);
        // }
        // catch (DivideByZeroException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Program Executed");
        // }


        // Example of try-catch-finally with a custom exception
        // try
        // {
        //     throw new Exception("This is a custom exception message.");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Program Executed");
        // }

        // Example of ArgumentOutOfRangeException
        // int number = -1;
        // try{
        //     if(number < 0)
        //     {
        //         throw new ArgumentOutOfRangeException("number", "Number must be non-negative.");
        //     }
        // }
        // catch (ArgumentOutOfRangeException ex)
        // {
        //     Console.WriteLine("Error Caused by: " + ex.ParamName);
        //     Console.WriteLine("Error Alert: " + ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Program Executed");
        // }

        // int n = 5;
        // try
        // {
        //     if (n > 3)
        //     {
        //         throw new Exception("n is greater than 3");
        //     }
        //     else {
        //         Console.WriteLine("n is less than or equal to 3");
        //     }
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine("Error Alert: " + ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Program Executed");
        // }

        // Custom Exception Example
        int a = -1;
        try
        {
            if (a < 0)
            {
                throw new MyOopException("Negative value is not allowed.");
            }
            else
            {
                Console.WriteLine("Value is valid: " + a);
            }
        }
        catch (MyOopException ex)
        {
            Console.WriteLine("Custom Exception Alert: " + ex.Message);
        }

    }
}