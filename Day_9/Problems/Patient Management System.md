# Patient Management System

#### Question :

Develop a simple patient diagnosis management system for a small medical clinic. The system needs to store patient information and track the symptoms they are diagnosed with.

- **Requirements :**

  - Store patient information using a structure where each patient has the following details :

        A unique identifier.

        Their name.

        Their age.

        A list of symptoms they have reported.

<br>

- Implement the following functionalities :

  - **AddPatient :** A function that adds a new patient’s information to the system.

  - **GetPatient :** A function that retrieves the details of a patient based on their unique identifier.

  - **GetPatientsBySymptom :** A function that returns the identifiers of all patients who have reported a specific symptom.

<br>

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Management_System
{
    internal class Patient_Management_System
    {
        static Dictionary<int, Dictionary<string, string>> Patients = new Dictionary<int, Dictionary<string, string>>();

        static int patient_id = 0;

        static void AddPatient()
        {
            Console.WriteLine("Enter the name : ");
            string patient_name = Console.ReadLine();

            Console.WriteLine("Enter the age : ");
            string patient_age = Console.ReadLine();

            Console.WriteLine("Enter the symptoms by comma seperated : ");
            string symptoms = Console.ReadLine();

            Dictionary<string, string> Temp = new Dictionary<string, string>();

            Temp.Add("patient_name", patient_name);
            Temp.Add("patient_age", patient_age);
            Temp.Add("symptoms", symptoms);

            Patients.Add(patient_id, Temp);
            patient_id++;
        }

        static void GetPatient()
        {
            Console.WriteLine("Enter the patient id : ");
            int id = int.Parse(Console.ReadLine());

            foreach (var Patient in Patients)
            {
                if (Patient.Key == id)
                {
                    foreach (var item in Patient.Value)
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                }
            }
        }

        static void GetPatientBySymptom()
        {
            Console.WriteLine("Enter the symptom : ");
            string symptom = Console.ReadLine();

            bool found = false;

            foreach (var Patient in Patients)
            {
                if (Patient.Value["symptoms"].Contains(symptom))
                {
                    Console.WriteLine();
                    foreach (var item in Patient.Value)
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                    Console.WriteLine();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No patients found with the given symptom.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n1 for AddPatient \n2 for GetPatient \n3 for GetPatientBySymptom \n\nEnter the value : ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        GetPatient();
                        break;
                    case 3:
                        GetPatientBySymptom();
                        break;

                    default:
                        Console.WriteLine("No match");
                        break;
                }
            }
        }
    }
}

```
