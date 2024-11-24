# Student Marks

#### Question :

Create a class `Student` with properties for `Name`, `Mark1`, `Mark2`, and `Mark3`. Implement methods to calculate and display the average and total marks of students.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public int AverageMark() => ((Mark1 + Mark2 + Mark3) / 3);

        public int TotalMark() => (Mark1 + Mark2 + Mark3);
    }

    internal class Student_Marks
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Clement";
            s.Mark1 = 70;
            s.Mark2 = 90;
            s.Mark3 = 30;

            Console.WriteLine($"Average Mark : {s.AverageMark()}");
            Console.WriteLine($"Total Mark : {s.TotalMark()}");

            Student s2 = new Student();
            s2.Name = "Sheba";
            s2.Mark1 = 72;
            s2.Mark2 = 89;
            s2.Mark3 = 96;

            Console.WriteLine($"\nAverage Mark : {s2.AverageMark()}");
            Console.WriteLine($"Total Mark : {s2.TotalMark()}");

            Student s3 = new Student();
            s3.Name = "Laly";
            s3.Mark1 = 40;
            s3.Mark2 = 60;
            s3.Mark3 = 80;

            Console.WriteLine($"\nAverage Mark : {s3.AverageMark()}");
            Console.WriteLine($"Total Mark : {s3.TotalMark()}");
        }
    }
}

```
