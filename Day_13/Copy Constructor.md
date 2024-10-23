# Copy Constructor

#### Discussed about :

    Concept of Copy Constructor.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        // Default constructor

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Copy constructor

        public Book(Book other)
        {
            Title = other.Title;
            Author = other.Author;
        }

        // Method to display the book details

        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
    internal class Copy_Constructor
    {
        static void Main(string[] args)
        {
            // Create the first book object

            Book originalBook = new Book("The Great Gatsby", "F. Scott Fitzgerald");

            Console.WriteLine("Original Book:");

            originalBook.DisplayDetails();

            // Create a copy of the first book using the copy constructor

            Book copiedBook = new Book(originalBook);

            Console.WriteLine("\nCopied Book:");

            copiedBook.DisplayDetails();
        }
    }
}

```
