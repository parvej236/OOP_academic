using System;

// Custom exception for invalid input
class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        DivideNumbers();
    }

    static void DivideNumbers()
    {
        try // Outer try for general exceptions
        {
            try // Inner try for known specific exceptions
            {
                Console.Write("Enter first number: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int n2 = int.Parse(Console.ReadLine());

                if (n1 <= 0 || n2 <= 0)
                {
                    throw new InvalidInputException("Only positive integers are allowed.");
                }

                int result = n1 / n2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZero Error: " + ex.Message);
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine("InvalidInput Error: " + ex.Message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
    }
}
