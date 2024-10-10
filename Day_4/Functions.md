# Functions

#### Discussed about :

    1. User defined function.
    2. Passing parameters to function.
    3. Function overloading.
    4. Single line function.
    5. Return keyword.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Functions
    {
        // User functions.
        static void Greet()
        {
            Console.WriteLine("Hello !");
        }

        // Passing parameters to function.
        static void GreetByName(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        // Function overloading.
        static void GreetByName(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}!");
        }

        // Single line function.
        static void SingleLineFunction() => Console.WriteLine("The single line function");

        // Single line function with return.
        static int SingleLineFunctionWithReturn(int a, int b) => a + b;

        // Main function.
        static void Main(string[] args)
        {
            Greet();
            GreetByName("Clement");
            GreetByName("Clement", "Mathew");

            Console.WriteLine();

            SingleLineFunction();
            Console.WriteLine(SingleLineFunctionWithReturn(1, 2));
        }
    }
}

```
