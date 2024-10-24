using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_and_Doctor_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            var patientManager = new PatientManager();
            var doctorManager = new DoctorManager();

            do
            {
                Console.WriteLine("\n1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. Add Doctor");
                Console.WriteLine("6. View Doctors");
                Console.WriteLine("7. Update Doctor");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Exit");

                Console.Write("\nEnter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        patientManager.AddPatient();
                        break;

                    case 2:
                        patientManager.ViewPatients();
                        break;

                    case 3:
                        patientManager.UpdatePatient();
                        break;

                    case 4:
                        patientManager.DeletePatient();
                        break;

                    case 5:
                        doctorManager.AddDoctor();
                        break;

                    case 6:
                        doctorManager.ViewDoctors();
                        break;

                    case 7:
                        doctorManager.UpdateDoctor();
                        break;

                    case 8:
                        doctorManager.DeleteDoctor();
                        break;

                    case 9:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 9);
        }
    }
}
