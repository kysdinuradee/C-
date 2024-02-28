using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_S2_Q1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Book object
            Book myBook = new Book();

            // Set values for the properties
            myBook.Title = "The Lord of the Rings";
            myBook.Author = "J.R.R. Tolkien";

            // Display book information
            Console.WriteLine($"Title: {myBook.Title}");
            Console.WriteLine($"Author: {myBook.Author}");
        }
    }
}
