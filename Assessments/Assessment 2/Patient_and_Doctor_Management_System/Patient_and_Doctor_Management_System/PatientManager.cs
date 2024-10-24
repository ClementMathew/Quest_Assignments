using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_and_Doctor_Management_System.Interfaces;
using Patient_and_Doctor_Management_System.Models;
using Patient_and_Doctor_Management_System.Repositories;
using static Patient_and_Doctor_Management_System.Models.GenderType;

namespace Patient_and_Doctor_Management_System
{
    internal class PatientManager : IPatient
    {
        private PatientRepository _repository;

        public PatientManager()
        {
            _repository = new PatientRepository();
        }

        public void DeletePatient()
        {
            Console.Write("\nEnter Patient Id : ");
            int id = int.Parse(Console.ReadLine());

            _repository.Delete(id);
        }

        public void UpdatePatient()
        {
            Console.Write("\nEnter Patient ID : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter new Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter new Medical Condition: ");
            string medicalCondition = Console.ReadLine();

            _repository.Update(id, name, age, medicalCondition);
        }

        public void ViewPatients()
        {
            var patients = _repository.View();

            foreach (var patient in patients)
            {
                Console.WriteLine($"{patient.Name} - {patient.Age} - {patient.Gender} - {patient.MedicalCondition}");
            }
        }

        public void AddPatient()
        {
            var patient = new Patient();

            Console.Write("\nEnter Name: ");
            patient.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            patient.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gender: ");

            Console.WriteLine("1. Male \n2. Female \n3. Others");
            int genderType = int.Parse(Console.ReadLine());

            if (genderType == 1)
            {
                patient.Gender = Gender.Male;
            }
            else if (genderType == 2)
            {
                patient.Gender = Gender.Female;
            }
            else
            {
                patient.Gender = Gender.Others;
            }

            Console.Write("Enter Medical Condition: ");
            patient.MedicalCondition = Console.ReadLine();

            _repository.Create(patient);
        }
    }
}
