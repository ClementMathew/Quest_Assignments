# Calculate Age

#### Question :

    Calculate the age of a person.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Age
{
    internal class Calculate_Age
    {
        static void Main(string[] args)
        {
            // Calculate the age of a person.

            Console.Write("Enter your Date of birth (DD/MM/YYYY) : ");
            DateTime Date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Parsed date : {Date}");

            DateTime dtt = DateTime.Now;

            int age = dtt.Year - Date.Year;

            // Adjust age if the birthday hasn't occurred yet this year.

            if (DateTime.Now < Date.AddYears(age))
            {
                age--;
            }

            Console.WriteLine($"Your age is : {age}");

        }
    }
}

```
