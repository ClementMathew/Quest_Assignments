# Student Marks by Array of Class

#### Question :

Create a class `Student` with `Name`, `Mark1`, and `Mark2` properties. Initialize an array of `Student` objects and display the names of students.

---

#### Code :

```c#

// Student Marks Array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marks_by_Array_of_Class
{
    internal class Student_Total_Mark_by_Array_of_Class
    {
        static void Main(string[] args)
        {
            var s1 = new Student
            {
                Name = "Student1",
                Mark1 = 10,
                Mark2 = 20
            };
            var s2 = new Student
            {
                Name = "Student2",
                Mark1 = 10,
                Mark2 = 20
            };
            var s3 = new Student
            {
                Name = "Student3",
                Mark1 = 10,
                Mark2 = 20
            };

            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            foreach (var student in students)
            {
                if (student != null)
                    Console.WriteLine(student.Name);
            }
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

namespace Student_Marks_by_Array_of_Class
{
    internal class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
    }
}

```
