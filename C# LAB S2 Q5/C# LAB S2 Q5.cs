using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_S2_Q5
{
    internal class Program
    {
        class LibraryBook
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public bool Available { get; set; } // True if available, False if borrowed

            public LibraryBook(string title, string author, bool available)
            {
                Title = title;
                Author = author;
                Available = available;
            }

            public void BorrowBook()
            {
                if (Available)
                {
                    Available = false;
                    Console.WriteLine($"Borrowed: {Title} by {Author}");
                }
                else
                {
                    Console.WriteLine($"{Title} by {Author} is currently unavailable.");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create book objects
                LibraryBook book1 = new LibraryBook("The Lord of the Rings", "J.R.R. Tolkien", true);
                LibraryBook book2 = new LibraryBook("Pride and Prejudice", "Jane Austen", true);
                LibraryBook book3 = new LibraryBook("The Hunger Games", "Suzanne Collins", false); // Already borrowed

                // User interaction loop
                while (true)
                {
                    Console.WriteLine("\nLibrary Menu:");
                    Console.WriteLine("1. Borrow a book");
                    Console.WriteLine("2. Display all books");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter book title to borrow: ");
                            string borrowTitle = Console.ReadLine();

                            if (borrowTitle == book1.Title)
                            {
                                book1.BorrowBook();
                            }
                            else if (borrowTitle == book2.Title)
                            {
                                book2.BorrowBook();
                            }
                            else if (borrowTitle == book3.Title)
                            {
                                book3.BorrowBook();
                            }
                            else
                            {
                                Console.WriteLine("Book not found in the library.");
                            }
                            break;
                        case 2:
                            Console.WriteLine("\nAvailable Books:");
                            if (book1.Available)
                            {
                                Console.WriteLine($"{book1.Title} by {book1.Author}");
                            }
                            if (book2.Available)
                            {
                                Console.WriteLine($"{book2.Title} by {book2.Author}");
                            }
                            Console.WriteLine($"{book3.Title} by {book3.Author} (Unavailable)");
                            break;
                        case 3:
                            Console.WriteLine("Exiting library management system...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
