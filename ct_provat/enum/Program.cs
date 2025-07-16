// learning enumaration

using System;

enum Days
{
    Sunday, // default value is 0
    Monday, // 1
    Tuesday,
    Wednesday = 10,
    Thursday,
    Friday,
    Saturday
}

enum ErrorCode
{
    NotFound = 404,
    BadRequest = 400,
    InternalServerError = 500,
    Unauthorized = 401
}
class Program
{
    static void Main(string[] args)
    {
        Days today = Days.Friday;

        switch (today)
        {
            case Days.Monday:
                Console.WriteLine("Start of the week!");
                break;
            case Days.Friday:
                Console.WriteLine("Almost weekend!");
                break;
            default:
                Console.WriteLine("It's just another day.");
                break;
        }

        Console.WriteLine((int)today); // Output: 5 (Friday)

        Console.WriteLine((int)ErrorCode.NotFound);
        Console.WriteLine(ErrorCode.BadRequest);
    }
}