# Abstract

#### Discussed about :

    Concept of Abstract.

---

#### Example Code :

```c#

using System;

namespace Abstract
{
    // Abstract base class

    abstract class StudentBase
    {
        // Property for student's name

        public string Name { get; set; }

        // Abstract method to be implemented by derived classes

        public abstract void Display();
    }

    // Derived class inheriting from StudentBase

    class Student : StudentBase
    {
        // Property for student's grade

        public string Grade { get; set; }

        // Implementing the abstract method

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        }
    }

    internal class Abstract
    {
        static void Main(string[] args)
        {
            // Create an instance of the derived class Student

            var student = new Student { Name = "John Doe", Grade = "A" };

            // Call the Display method

            student.Display();
        }
    }
}

```
