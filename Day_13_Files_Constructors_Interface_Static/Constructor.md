# Constructor

#### Discussed about :

    1. Default Constructor.
    2. Parametrized Constructor.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Person
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string[] PhoneNumbers { get; set; }

        // Default constructor

        public Person()
        {
            Name = "Unknown";
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[0];  // Initializes an empty array for phone numbers
        }

        // Constructor that only accepts the number of phone numbers

        public Person(int phoneNumberCount)
        {
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[phoneNumberCount];
        }

        // Constructor that accepts both name and number of phone numbers

        public Person(string name, int phoneNumberCount)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[phoneNumberCount];
        }

        // Method to display the person's details

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Created At: {CreatedAt}");
            Console.WriteLine($"Phone Numbers Count: {PhoneNumbers.Length}");
        }
    }

    internal class Constructor
    {
        static void Main(string[] args)
        {
            // Creating Person object using the default constructor

            var personDefault = new Person();

            personDefault.DisplayInfo();

            Console.WriteLine();

            // Creating Person object using first constructor

            var person1 = new Person(2);
            person1.Name = "John";

            person1.DisplayInfo();

            Console.WriteLine();

            // Creating Person object using second constructor

            var person2 = new Person("Mishel", 5);

            person2.DisplayInfo();
        }
    }
}

```
