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

        for (int i = 5; i > 0; i--)
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
    }
}