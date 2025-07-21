using System;

class InvalidIndexException : Exception
{
    public InvalidIndexException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        try
        {
            try
            {
                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    throw new InvalidIndexException("Index should not be negative");
                }

                int value = arr[index];
                Console.WriteLine("Value: " + value);
            }
            catch (InvalidIndexException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // throw; // use when outer catch should have the same exception message
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
