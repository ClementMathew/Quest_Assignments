using System;
using System.IO;
using EmployeeManagement.Entities;
using Newtonsoft.Json;

namespace EmployeeManagement.Services
{
    class JsonFileStorage : IStorageService
    {
        private readonly string _storageDirectory;

        public JsonFileStorage()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storageDirectory = Path.Combine(documentsPath, "EmployeeManagement(DotNet)", "JsonData");

            Directory.CreateDirectory(_storageDirectory);
        }

        public void Delete(string id)
        {
            var filePath = Path.Combine(_storageDirectory, $"{id}.json");
            File.Delete(filePath);
        }

        public void Save(Employee employee)
        {
            var jsonText = JsonConvert.SerializeObject(employee);
            var filePath = Path.Combine(_storageDirectory, $"{employee.Id}.json");

            File.WriteAllText(filePath, jsonText);
        }

        public Employee Search(string name)
        {
            var files = Directory.GetFiles(_storageDirectory);

            foreach (var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                Employee employee = JsonConvert.DeserializeObject<Employee>(fileContentJson);

                var employeeName = employee.FullName.ToLowerInvariant();
                var nameToSearch = name.ToLowerInvariant();

                if (employeeName.Contains(nameToSearch))
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
