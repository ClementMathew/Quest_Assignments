using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books_Manager.Services;

namespace Books_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var bookManager = new BookManager(storageService);

            bookManager.Run();
        }
    }
}
