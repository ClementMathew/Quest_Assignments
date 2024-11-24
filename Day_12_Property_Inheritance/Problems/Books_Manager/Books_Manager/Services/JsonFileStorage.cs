using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books_Manager.Entities;
using Newtonsoft.Json;

namespace Books_Manager.Services
{
    internal class JsonFileStorage : IStorageService
    {
        private readonly string _storageDirectory;

        public JsonFileStorage()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storageDirectory = Path.Combine(documentsPath, "BookManagement (DotNet)", "JsonData");

            Directory.CreateDirectory(_storageDirectory);
        }

        public void Delete(string id)
        {
            var filePath = Path.Combine(_storageDirectory, $"{id}.json");

            File.Delete(filePath);
        }

        public void Save(Book book)
        {
            var jsonText = JsonConvert.SerializeObject(book);
            var filePath = Path.Combine(_storageDirectory, $"{book.Id}.json");

            File.WriteAllText(filePath, jsonText);
        }

        public Book Search(string query)
        {
            var files = Directory.GetFiles(_storageDirectory);

            foreach (var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                Book book = JsonConvert.DeserializeObject<Book>(fileContentJson);

                var fullText = $"{book.Title} {book.Author}".ToLowerInvariant();
                var queryToSearch = query.ToLowerInvariant();

                if (fullText.Contains(queryToSearch))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
