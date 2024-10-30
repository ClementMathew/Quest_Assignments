using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var employeeManager = new EmployeeManager(storageService);

            employeeManager.Run();
        }
    }
}
