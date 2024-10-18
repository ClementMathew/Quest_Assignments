# College and School Student

#### Question :

Create an abstract class `Student` with properties `Name` and `Email`. Derive two classes: `College` (with `CollegeName`) and `School` (with `SchoolName`). Override the `ToString()` method in both to display the student details.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_and_School_Student
{

    abstract class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class College : Student
    {
        public string CollegeName { get; set; }

        public override string ToString()
        {
            return $"The student {Name} with id {Email} studying in {CollegeName}";
        }
    }
    class School : Student
    {
        public string SchoolName { get; set; }
        public override string ToString()
        {
            return $"The student {Name} with id {Email} studying in {SchoolName}";
        }
    }

    internal class College_and_School_Student
    {
        static void Main(string[] args)
        {
            College stud = new College();

            stud.Name = "Clement";
            stud.Email = "clement@mail.com";
            stud.CollegeName = "Gec Wayanad";

            School stud1 = new School();

            stud1.Name = "John";
            stud1.Email = "john@mail.com";
            stud1.SchoolName = "GHS Ayoor";

            Console.WriteLine(stud);
            Console.WriteLine(stud1);
        }
    }
}

```
