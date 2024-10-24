using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_and_Doctor_Management_System.Interfaces;
using Patient_and_Doctor_Management_System.Models;
using Patient_and_Doctor_Management_System.Repositories;
using static Patient_and_Doctor_Management_System.Models.Types.SpecializationType;

namespace Patient_and_Doctor_Management_System
{
    internal class DoctorManager : IDoctor
    {
        private DoctorRepository _repository;

        public DoctorManager()
        {
            _repository = new DoctorRepository();
        }

        public void AddDoctor()
        {
            var doctor = new Doctor();

            Console.Write("\nEnter Name: ");
            doctor.Name = Console.ReadLine();

            Console.Write("Enter Specialization : ");

            Console.Write("1. Cardiologist \n2. Neurologist \n3. Others");
            int specializationType = int.Parse(Console.ReadLine());

            if (specializationType == 1)
            {
                doctor.Specialization = Specializations.Cardiologist;
            }
            else if (specializationType == 2)
            {
                doctor.Specialization = Specializations.Neurologist;
            }
            else
            {
                doctor.Specialization = Specializations.Others;
            }

            Console.Write("Enter Patient Id : ");
            doctor.PatientId = int.Parse(Console.ReadLine());

            _repository.Create(doctor);
        }

        public void DeleteDoctor()
        {
            Console.Write("\nEnter Doctor Id : ");
            int id = int.Parse(Console.ReadLine());

            _repository.Delete(id);
        }

        public void UpdateDoctor()
        {
            Console.Write("\nEnter Doctor ID : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter new Name: ");
            string name = Console.ReadLine();

            _repository.Update(id, name);
        }

        public void ViewDoctors()
        {
            var doctors = _repository.View();

            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.Name} - {doctor.Specialization} - {doctor.PatientId}");
            }
        }
    }
}
