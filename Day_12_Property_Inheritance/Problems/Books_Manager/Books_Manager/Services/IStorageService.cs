using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books_Manager.Entities;

namespace Books_Manager.Services
{
    internal interface IStorageService
    {
        void Save(Book book);
        void Delete(string id);
        Book Search(string query);
    }
}
