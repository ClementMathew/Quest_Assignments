# Health Care

#### Question :

1. **List Upcoming Appointments**  
   How can you use LINQ to list all patients with appointments within the next 7 days? Include patient name, age, and medical condition.

2. **Group Patients by Medical Condition**  
   How can you group patients by their medical condition and count those with upcoming appointments?

3. **Find Patients with Most Appointments**  
   Using LINQ, how would you identify the patient(s) with the most appointments in the last 30 days?

4. **Retrieve Most Recent Appointment for Patients Over 60**  
   How can you list patients over the age of 60 along with details of their most recent appointment? Include doctor name, appointment date, and type.

<br>

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;

namespace Health_Care_Management_System
{
    internal class Health_Care_Management_System
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>
            {
                new Patient{Id = 1, Name = "Gatha", Age = 23, Gender ="Female", MedicalCondition = "Fever"},
                new Patient{Id = 2, Name = "Minnu", Age = 50, Gender ="Female", MedicalCondition = "Headache"},
                new Patient{Id = 3, Name = "Mohan", Age = 70, Gender = "Male", MedicalCondition = "Fracture"},
                new Patient{Id = 4, Name = "Aryan", Age = 60, Gender = "Male", MedicalCondition = "Vomiting"}
            };
            patients.Add(new Patient { Id = 5, Name = "Raghav", Age = 60, Gender = "Male", MedicalCondition = "Diarrhea" });

            var appointments = new List<Appointment>
            {
                new Appointment{Id = 1, PatientId = 1, DoctorName = "Mathew", AppointmentDate = new DateTime(2024, 10, 22), AppointmentType = "Consultation"},
                new Appointment{Id = 2, PatientId = 2, DoctorName = "Mathew", AppointmentDate = new DateTime(2024, 10, 23), AppointmentType = "Consultation"},
                new Appointment{Id = 3, PatientId = 3, DoctorName = "George", AppointmentDate = new DateTime(2024, 11, 02), AppointmentType = "Surgery"},
                new Appointment{Id = 4, PatientId = 4, DoctorName = "Samuel", AppointmentDate = new DateTime(2024, 10, 22), AppointmentType = "Consultation"},
                new Appointment{Id = 5, PatientId = 1, DoctorName = "Mathew", AppointmentDate = new DateTime(2024, 10, 30), AppointmentType = "Follow-up"}
            };

            // 1. List all patients with upcoming appointments within the next 7 days

            var upcomingAppointments = patients
                .Join(appointments,
                      p => p.Id,
                      a => a.PatientId,
                      (patient, appointment) => new
                      {
                          patient.Name,
                          patient.Age,
                          patient.MedicalCondition,
                          appointment.AppointmentDate
                      })
                .Where(x => x.AppointmentDate >= DateTime.Now && x.AppointmentDate <= DateTime.Now.AddDays(7));

            Console.WriteLine("Upcoming Appointments in the next 7 days:");

            foreach (var detail in upcomingAppointments)
            {
                Console.WriteLine($"Name: {detail.Name}, Age: {detail.Age}, Medical Condition: {detail.MedicalCondition}");
            }

            // 2. Group patients by MedicalCondition and count those with upcoming appointments

            var groupedByCondition = patients
                .Join(appointments,
                      p => p.Id,
                      a => a.PatientId,
                      (patient, appointment) => new
                      {
                          patient.Name,
                          patient.MedicalCondition,
                          appointment.AppointmentDate
                      })
                .Where(x => x.AppointmentDate >= DateTime.Now)
                .GroupBy(x => x.MedicalCondition)
                .Select(g => new { Condition = g.Key, Count = g.Count() });

            Console.WriteLine("\nPatients grouped by Medical Condition with upcoming appointments:");

            foreach (var group in groupedByCondition)
            {
                Console.WriteLine($"Condition: {group.Condition}, Count: {group.Count}");
            }

            // 3. Find patient(s) with the most appointments in the last 30 days

            var mostAppointments = appointments
                .Where(x => x.AppointmentDate <= DateTime.Now && x.AppointmentDate >= DateTime.Now.AddDays(-30))
                .GroupBy(x => x.PatientId)
                .Select(g => new { PatientId = g.Key, AppointmentCount = g.Count() })
                .OrderByDescending(g => g.AppointmentCount)
                .ToList();

            var maxAppointmentCount = mostAppointments.First().AppointmentCount;

            var patientsWithMostAppointments = mostAppointments
                .Where(g => g.AppointmentCount == maxAppointmentCount)
                .Select(g => g.PatientId);

            Console.WriteLine("\nPatient(s) with the most appointments in the last 30 days:");

            foreach (var patientId in patientsWithMostAppointments)
            {
                var patient = patients.FirstOrDefault(p => p.Id == patientId);
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Medical Condition: {patient.MedicalCondition}");
            }

            // 4. Patients over age 60 with their most recent appointment details

            var patientsOver60 = patients
                .Join(appointments,
                      p => p.Id,
                      a => a.PatientId,
                      (patient, appointment) => new
                      {
                          patient.Name,
                          patient.Age,
                          patient.MedicalCondition,
                          appointment.DoctorName,
                          appointment.AppointmentDate,
                          appointment.AppointmentType
                      })
                .Where(x => x.Age > 60)
                .GroupBy(x => new { x.Name, x.Age, x.MedicalCondition })
                .Select(g => new
                {
                    Patient = g.Key,
                    MostRecentAppointment = g.OrderByDescending(x => x.AppointmentDate).FirstOrDefault()
                });

            Console.WriteLine("\nPatients over age 60 with their most recent appointment:");

            foreach (var patientGroup in patientsOver60)
            {
                Console.WriteLine($"Patient Name: {patientGroup.Patient.Name}, Age: {patientGroup.Patient.Age}, Medical Condition: {patientGroup.Patient.MedicalCondition}");
                Console.WriteLine($"Most Recent Appointment - Doctor: {patientGroup.MostRecentAppointment.DoctorName}, Date: {patientGroup.MostRecentAppointment.AppointmentDate}, Type: {patientGroup.MostRecentAppointment.AppointmentType}");
                Console.WriteLine();
            }
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }
    }

    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentType { get; set; }
    }
}

```
