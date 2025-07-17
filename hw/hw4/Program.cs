using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        class Book
        {
            public int Id { get; set; }
            public string Title { get; set }
            public int PageCount { get; set; }

            public Book(int id, string title, int pageCount)
            {
                Id = id;
                Title = title;
                PageCount = pageCount;
            }

            public override string ToString()
            {
                return $"{Id} Book Title: \"{Title}\", Pages: {PageCount}";
            }
        }

        class Journal
        {
            public int Id { get; }
            public string Title { get; }
            public int IssueNumber { get; }

            public Journal(int id, string title, int issueNumber)
            {
                Id = id;
                Title = title;
                IssueNumber = issueNumber;
            }

            public override string ToString()
            {
                return $"{Id} Journal Title: \"{Title}\", Issue: {IssueNumber}";
            }
        }

        class DVD
        {
            public int Id { get; }
            public string Title { get; }
            public float Duration { get; }

            public DVD(int id, string title, float duration)
            {
                Id = id;
                Title = title;
                Duration = duration;
            }

            public override string ToString()
            {
                return $"{Id} DVD Title: \"{Title}\", Duration: {Duration} min";
            }
        }

        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            List<Journal> journals = new List<Journal>();
            List<DVD> dvds = new List<DVD>();

            int bookId = 1, journalId = 1, dvdId = 1;

            while (true)
            {
                Console.WriteLine("\n-- Menu --");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Add a journal");
                Console.WriteLine("3. Add a DVD");
                Console.WriteLine("4. List items");
                Console.WriteLine("5. Exit");
                Console.Write("Enter a choice: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter book title: ");
                        string bookTitle = Console.ReadLine();
                        Console.Write("Enter page count: ");
                        int pageCount = int.Parse(Console.ReadLine());
                        books.Add(new Book(bookId++, bookTitle, pageCount));
                        break;

                    case "2":
                        Console.Write("Enter journal title: ");
                        string journalTitle = Console.ReadLine();
                        Console.Write("Enter issue number: ");
                        int issueNum = int.Parse(Console.ReadLine());
                        journals.Add(new Journal(journalId++, journalTitle, issueNum));
                        break;

                    case "3":
                        Console.Write("Enter DVD title: ");
                        string dvdTitle = Console.ReadLine();
                        Console.Write("Enter duration (in minutes): ");
                        float duration = float.Parse(Console.ReadLine());
                        dvds.Add(new DVD(dvdId++, dvdTitle, duration));
                        break;

                    case "4":
                        Console.WriteLine("\n--- Book List ---");
                        Console.WriteLine("ID \t Type \t Details");
                        foreach (var book in books) {
                            Console.WriteLine(book);
                        }

                        Console.WriteLine("\n--- Journal List ---");
                        Console.WriteLine("ID \t Type \t Details");
                        foreach (var journal in journals) {
                            Console.WriteLine(journal);
                        }

                        Console.WriteLine("\n--- DVD List ---");
                        Console.WriteLine("ID \t Type \t Details");
                        foreach (var dvd in dvds) {
                            Console.WriteLine(dvd);
                        }
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
