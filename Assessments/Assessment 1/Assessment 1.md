# Group 2 - Hospital Management System

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Hospital_Management_System
    {
        static Dictionary<string, Dictionary<string, Dictionary<string, string>>> Departments = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();

        static void SearchPatient()
        {
            Console.WriteLine("Enter the patient name to search: ");
            string patientName = Console.ReadLine().ToUpper();

            bool patientFound = false;

            foreach (var department in Departments)
            {
                foreach (var doctor in department.Value)
                {
                    if (doctor.Value.ContainsKey(patientName))
                    {
                        Console.WriteLine($"\nPatient {patientName} is in {department.Key} department, under doctor {doctor.Key}.");
                        Console.WriteLine($"Status: {doctor.Value[patientName]}");

                        patientFound = true;
                        break;
                    }
                }
                if (patientFound)
                {
                    break;
                }
            }

            if (!patientFound)
            {
                Console.WriteLine("No such patient found!");
            }
        }

        static void SearchDoctor()
        {
            Console.WriteLine("Enter the doctor name to search: ");
            string doctorName = Console.ReadLine().ToUpper();

            bool doctorFound = false;

            foreach (var department in Departments)
            {
                foreach (var doctor in department.Value)
                {

                    if (doctor.Key.Equals(doctorName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"\nDoctor {doctorName} is in the {department.Key} department.");

                        Console.WriteLine("Patients under this doctor:");
                        foreach (var patient in doctor.Value)
                        {
                            Console.WriteLine($"    Patient: {patient.Key}, Status: {patient.Value}");
                        }
                        doctorFound = true;
                        break;
                    }
                }
                if (doctorFound)
                {
                    break;
                }
            }

            if (!doctorFound)
            {
                Console.WriteLine("No such doctor found!");
            }
        }

        static void DischargePatient()
        {
            Console.WriteLine("Enter the patient name : ");
            string patientName = Console.ReadLine().ToUpper();

            bool patientFound = false;

            foreach (var department in Departments)
            {
                foreach (var doctor in department.Value)
                {
                    if (doctor.Value.ContainsKey(patientName))
                    {
                        patientFound = true;

                        doctor.Value[patientName] = "Discharged";

                        Console.WriteLine($"\nPatient {patientName} has been discharged from {doctor.Key} in {department.Key} department.");
                        break;
                    }
                }
                if (patientFound)
                {
                    break;
                }
            }

            if (!patientFound)
            {
                Console.WriteLine("No such patient found!");
            }
        }

        static void ListPatients()
        {
            Console.WriteLine("----------- Patients ------------");

            foreach (var department in Departments)
            {
                Console.WriteLine($"{department.Key} : ");

                foreach (var doctor in department.Value)
                {
                    Console.WriteLine($"    {doctor.Key} : ");

                    foreach (var patient in doctor.Value)
                    {
                        Console.WriteLine($"        {patient.Key} : {patient.Value}");
                    }
                }
            }
        }

        static void ListDoctors()
        {
            Console.WriteLine("-------- Doctors --------------");

            foreach (var department in Departments)
            {
                Console.WriteLine($"{department.Key} : ");

                foreach (var doctor in department.Value)
                {
                    Console.WriteLine($"    {doctor.Key}");
                }
            }
        }

        static void AdmitPatient()
        {
            Dictionary<string, Dictionary<string, string>> Doctors = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> Patients = new Dictionary<string, string>();

            Console.WriteLine("Enter the department name : ");
            string departmentName = Console.ReadLine().ToUpper();

            bool departmentFound = false;
            bool doctorFound = false;

            foreach (var department in Departments)
            {
                if (department.Key == departmentName)
                {
                    departmentFound = true;

                    Doctors = Departments[departmentName];

                    Console.WriteLine("Enter the name of doctor : ");
                    string doctorName = Console.ReadLine().ToUpper();

                    foreach (var doctor in department.Value)
                    {
                        if (doctor.Key == doctorName)
                        {
                            doctorFound = true;
                            Patients = Doctors[doctorName];

                            Console.WriteLine("Enter the name of patient : ");
                            string patientName = Console.ReadLine().ToUpper();

                            Patients.Add(patientName, "Admitted");
                        }
                    }
                    if (!doctorFound)
                    {
                        Console.WriteLine("No doctor found !");
                    }
                    else
                    {
                        Doctors[doctorName] = Patients;
                    }
                }
            }
            if (!departmentFound)
            {
                Console.WriteLine("No such department !");
            }
            else
            {
                Departments[departmentName] = Doctors;
            }
        }

        static void AddDoctor()
        {
            Dictionary<string, Dictionary<string, string>> Doctors = new Dictionary<string, Dictionary<string, string>>();
            bool departmentFound = false;

            Console.WriteLine("Enter the department name : ");
            string departmentName = Console.ReadLine().ToUpper();

            foreach (var department in Departments)
            {
                if (department.Key == departmentName)
                {
                    departmentFound = true;
                    Doctors = Departments[departmentName];

                    Console.WriteLine("Enter the names of doctors by separated commas : ");
                    string doctorsNames = Console.ReadLine().ToUpper();

                    List<string> doctors = new List<string>(doctorsNames.Split(','));

                    foreach (var name in doctors)
                    {
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            Dictionary<string, string> Patients = new Dictionary<string, string>();
                            Doctors.Add(name, Patients);
                        }
                    }
                }
            }
            if (!departmentFound)
            {
                Console.WriteLine("No such department !");
            }
            else
            {
                Departments[departmentName] = Doctors;
            }
        }

        static void AddDepartment()
        {
            Dictionary<string, Dictionary<string, string>> Doctors = new Dictionary<string, Dictionary<string, string>>();

            Console.WriteLine("Enter the department name : ");
            string departmentName = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter the names of doctors by separated commas : ");
            string doctorsNames = Console.ReadLine().ToUpper();

            if (!string.IsNullOrWhiteSpace(doctorsNames))
            {
                List<string> doctors = new List<string>(doctorsNames.Split(','));

                foreach (var name in doctors)
                {
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        Dictionary<string, string> Patients = new Dictionary<string, string>();
                        Doctors.Add(name, Patients);
                    }
                }
                Departments.Add(departmentName, Doctors);
            }
            else
            {
                Departments.Add(departmentName, Doctors);

            }
        }

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1. Add new department \n2. Add doctors \n3. Admit Patient \n4. List doctors \n5. List patients \n6. Discharge patient \n7. Search doctor \n8. Search patient \n9. Exit \n\nEnter value : ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddDepartment();
                        break;

                    case 2:
                        AddDoctor();
                        break;

                    case 3:
                        AdmitPatient();
                        break;

                    case 4:
                        ListDoctors();
                        break;

                    case 5:
                        ListPatients();
                        break;

                    case 6:
                        DischargePatient();
                        break;

                    case 7:
                        SearchDoctor();
                        break;

                    case 8:
                        SearchPatient();
                        break;

                    case 9:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

```
