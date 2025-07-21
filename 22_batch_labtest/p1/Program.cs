using System;

class Program
{
    static void Main(string[] args)
    {
        // for (int i = 0; i < 5; i++)
        // {
        //     for (int j = 0; j < i; j++)
        //     {
        //         Console.Write("  ");
        //     }
        //     for (int j = 0; j < 5 - i; j++)
        //     {
        //         Console.Write($" {j + 1}");
        //     }
        //     Console.WriteLine();
        // }

        for (int i = 5; i >= 0; i--)
        {

            for (int j = i; j > 0; j--)
            {
                Console.Write($" {j}");
            }

            for (int j = 0; j < 5 - i; j++)
            {
                Console.Write("  ");
            }
            Console.WriteLine();
        }

        // code for check prime number
        Console.Write("Enter a number to check if it is prime: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = number > 1;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine($"{number} is a prime number.");
        else
            Console.WriteLine($"{number} is not a prime number.");
        
    }
}