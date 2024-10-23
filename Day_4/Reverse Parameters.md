# Reverse Parameters

#### Discussed about :

    Passing parameters in reverse order.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Parameter
{
    internal class Reverse_Parameter
    {
        // Function that accepts parameters in reverse order

        static void PrintInfo(string firstName, string lastName, int age)
        {
            Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}, Age: {age}");
        }

        static void Main(string[] args)
        {
            // Calling the function with parameters in reverse order

            PrintInfo(lastName: "Doe", firstName: "John", age: 25);
        }
    }
}

```
