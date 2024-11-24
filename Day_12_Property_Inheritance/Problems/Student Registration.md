# Student Registration

#### Question :

Create a `Student Registration` system that allows students to register with their name, registration number, class, and marks in multiple subjects.

The system should support the following operations:

1. **Register a new student.**

2. **Search for a student by their registration number.**

3. **Update student details.**

4. **Remove a student from the system.**

<br>

Include classes for `Student`, `Marks`, and a `RegistrationManagement` system to handle these operations.

---

#### Code :

```c#

// Student Registration Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class Student_Registration
    {
        static RegistrationManagement manage = new RegistrationManagement();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Register Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Remove Student");
                Console.WriteLine("5. Exit");

                Console.Write("\nSelect an option : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetStudentData();
                        break;

                    case "2":
                        SearchStudentData();
                        break;

                    case "3":
                        UpdateStudentData();
                        break;

                    case "4":
                        DeleteStudentData();
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("\nExiting...");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }
            }
        }

        private static void DeleteStudentData()
        {
            Console.WriteLine("\nEnter the registration number : ");
            string regNum = Console.ReadLine();

            manage.DeleteStudent(regNum);
        }

        private static void UpdateStudentData()
        {
            Console.WriteLine("\nEnter registration number : ");
            string regNum = Console.ReadLine();

            Console.WriteLine("Enter the new name : ");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter the new class : ");
            string newClass = Console.ReadLine();

            manage.UpdateStudent(regNum, newName, newClass);
        }

        private static void SearchStudentData()
        {
            Console.WriteLine("\nEnter the registration number : ");
            string regNum = Console.ReadLine();

            manage.SearchStudent(regNum);
        }

        private static void GetStudentData()
        {
            Console.WriteLine("\nEnter name of student : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter registration number : ");
            string regNum = Console.ReadLine();

            Console.WriteLine("Enter class : ");
            string @class = Console.ReadLine();

            List<Marks> marks = new List<Marks>();

            while (true)
            {
                Marks mark = new Marks();

                Console.WriteLine("Do you want to add marks (Yes/No) : ");
                string status = Console.ReadLine();

                if (status == "Yes")
                {
                    Console.WriteLine("Enter the subject name : ");
                    string subName = Console.ReadLine();

                    Console.WriteLine("Enter the max marks ; ");
                    int maxMarks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the scored marks ; ");
                    int scoredMarks = int.Parse(Console.ReadLine());

                    mark.SubjectName = subName;
                    mark.MaxMark = maxMarks;
                    mark.MarkScored = scoredMarks;

                    marks.Add(mark);
                }
                else
                {
                    break;
                }
            }

            manage.RegisterStudent(name, regNum, @class, marks);
        }
    }
}

```

```c#

// Student Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class Student
    {
        public string Name;
        public string RegNumber;
        public string Class;
        public List<Marks> Marks;

        public void DisplayStudent()
        {
            Console.WriteLine($"\nThe student {Name} is registered with {RegNumber} to the class {Class}.\n\nMarks\n---------------\n");
            ShowMarks();
        }

        public void ShowMarks()
        {
            foreach (Marks mark in Marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}

```

```c#

// Registration Management Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class RegistrationManagement
    {
        private List<Student> students = new List<Student>();

        public void RegisterStudent(string name, string regNum, string @class, List<Marks> marks)
        {
            Student student = new Student();

            student.Name = name;
            student.RegNumber = regNum;
            student.Class = @class;
            student.Marks = marks;

            students.Add(student);

            Console.WriteLine("\nAdded successfully !");
        }

        public void SearchStudent(string regNum)
        {
            foreach (var student in students)
            {
                if (student.RegNumber == regNum)
                {
                    student.DisplayStudent();
                    return;
                }
            }
            Console.WriteLine("\nNot found !");
        }

        public void UpdateStudent(string regNum, string newName, string newClass)
        {
            foreach (var student in students)
            {
                if (student.RegNumber == regNum)
                {
                    student.Name = newName;
                    student.Class = newClass;

                    Console.WriteLine("\nUpdated successfully !");
                    return;
                }
            }
            Console.WriteLine("\nNo such student to update s!");
        }

        public void DeleteStudent(string regNum)
        {
            foreach (var student in students)
            {
                if (student.RegNumber == regNum)
                {
                    students.Remove(student);
                    Console.WriteLine("\nDeleted successfully !");
                    return;
                }
            }
            Console.WriteLine("\nNo such student to delete !");
        }
    }
}

```

```c#

// Mark Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class Marks
    {
        public string SubjectName;
        public int MarkScored;
        public int MaxMark;

        public override string ToString()
        {
            return $"Scored {MarkScored} out of {MaxMark} in {SubjectName}.";
        }
    }
}

```
