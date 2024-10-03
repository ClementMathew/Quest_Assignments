# Introduction

Discussed about :

    1. Console IO Methods
    2. Concatination
    3. Casing Types

---

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
internal class Basics
{
static void Main(string[] args)
{
            // New line printing.

            Console.WriteLine(1);
            Console.WriteLine(true);
            Console.WriteLine(10.56);
            Console.WriteLine("Hello World \n");

            // Same line printing.

            Console.Write("Line 1");
            Console.Write(" Line 2 \n");
            Console.WriteLine();

            // Concatination.

            string name = "Clement";
            string message = "My name is ";

            Console.WriteLine(name);
            Console.WriteLine(message + name);
            Console.WriteLine();

            // Camel casing and spacing.

            string firstName = "Clement";
            string lastName = "Mathew";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);
            Console.WriteLine();

            // Concatinating string and int.

            int age = 25;

            string person = fullName + " is " + age + " years old.";
            Console.WriteLine(person);

            string person2 = $"{fullName} is {age} years old.";
            Console.WriteLine(person2);

            // User input.

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("What is your name ?");
            string nameInput = Console.ReadLine();
            Console.WriteLine($"Hello {nameInput}! \n");

            // Sum of two numbers.

            Console.WriteLine("Enter the first number : ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter the second number : ");
            string num2 = Console.ReadLine();

            Console.WriteLine($"Sum is {num1 + num2}");
        }
    }

}
```
