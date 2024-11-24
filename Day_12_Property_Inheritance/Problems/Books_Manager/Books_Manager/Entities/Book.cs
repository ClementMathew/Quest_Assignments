using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Manager.Entities
{
    internal class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; } //  (International Standard Book Number) of the book.
        public string Category { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Author: {Author}, ISBN: {ISBN}, Category: {Category}";
        }
    }
}
