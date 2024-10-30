using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Services
{
    internal interface IStorageService
    {
        void Save(Employee employee);

        void Delete(string id);

        Employee Search(string name);
    }
}
