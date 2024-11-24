# Const and Readonly

#### Discussed about :

    1. Const keyword.
    2. Readonly keyword.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_and_Readonly
{
    class Constants
    {
        // const field : Must be assigned a value at declaration and cannot be changed

        public const double Pi = 3.14159;

        // readonly field : Can be assigned at declaration or in the constructor, but not modified after that

        public readonly int YearOfCreation;

        public Constants(int year)
        {
            YearOfCreation = year; // readonly can be assigned in the constructor
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Constant Pi: {Pi}");
            Console.WriteLine($"Year of Creation (readonly): {YearOfCreation}");
        }
    }

    internal class Const_and_Readonly
    {
        static void Main(string[] args)
        {
            // Creating an object of Constants and initializing the readonly field

            Constants constants = new Constants(2024);

            // Displaying values of const and readonly fields

            constants.DisplayValues();

            // constants.Pi = 3.14;   // Error: Cannot modify a const field

            // constants.YearOfCreation = 2025;  // Error: Cannot modify a readonly field outside the constructor
        }
    }
}

```
