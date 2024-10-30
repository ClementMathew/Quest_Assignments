using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books_Manager.Entities;
using Books_Manager.Services;

namespace Books_Manager
{
    internal class BookManager
    {
        private readonly IStorageService _storageService;

        public BookManager(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void Add()
        {
            var book = new Book();
            book.Id = Guid.NewGuid().ToString();

            Console.Write("\nTitle: ");
            book.Title = Console.ReadLine();

            Console.Write("Author: ");
            book.Author = Console.ReadLine();

            Console.Write("ISBN: ");
            book.ISBN = Console.ReadLine();

            Console.Write("Category: ");
            book.Category = Console.ReadLine();

            _storageService.Save(book);
        }

        public void Remove()
        {
            Console.Write("\nEnter the book id: ");
            var id = Console.ReadLine();

            _storageService.Delete(id);
        }

        public void Search()
        {
            Console.Write("\nEnter the book title or author: ");
            var searchQuery = Console.ReadLine();

            var book = _storageService.Search(searchQuery);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            Console.WriteLine(book);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Delete Book");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;

                    case "2":
                        Search();
                        break;

                    case "3":
                        Remove();
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
