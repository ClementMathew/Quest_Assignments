using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Services
{
    internal class CustomStorageService : IStorageService
    {
        public void Delete(string id) => throw new NotImplementedException();
        public void Save(Employee employee) => throw new NotImplementedException();
        public Employee Search(string name) => throw new NotImplementedException();
    }
}
