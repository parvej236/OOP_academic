using System;

namespace HelloWorld
{
  class Book
  {
    public string BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string bookId, string title, string author, bool isAvailable)
    {
      BookId = bookId;
      Title = title;
      Author = author;
      IsAvailable = isAvailable;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      int n;
      Console.Write("Enter the number of books (1-10): ");
      n = int.Parse(Console.ReadLine());

      if(n < 1 || n > 10)
      {
        Console.WriteLine("Error: Number of books must be between 1 and 10.");
        return;
      }

      Book[] books = new Book[n];

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"\nEnter details for Book {i + 1}:");

        Console.Write("Book ID: ");
        string bookId = Console.ReadLine();

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Author: ");
        string author = Console.ReadLine();

        Console.Write("Is the book available? (yes/no): ");
        string availabilityInput = Console.ReadLine();
        bool isAvailable = (availabilityInput == "yes") ? true : false;

        books[i] = new Book(bookId, title, author, isAvailable);
      }

      Console.WriteLine("\nAvailable Books:");
      bool flag = false;

      foreach (Book book in books)
      {
        if (book.IsAvailable)
        {
          Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}");
          flag = true;
        }
      }

      if (!flag)
      {
        Console.WriteLine("No books are currently available.");
      }
    }
  }
}