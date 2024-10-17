# Dictionary Collection

#### Discussed about :

    Introduction to Dictionary.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Dictionary
    {
        static void Main(string[] args)
        {
            // Dictionary declarations.

            Dictionary<string, string> dict = new Dictionary<string, string>();

            // Displaying the values.

            Console.WriteLine("Key value pair from dict : ");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();

            // Another declaration

            var dict2 = new Dictionary<string, string>()
            {
               { "first name","gatha"},
               { "age","20" }
            };

            Console.WriteLine("Key value pair from dict2 : ");

            foreach (var item in dict2)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();

            // Accessing a value.

            Console.WriteLine($"Accessing first name in dict2 : {dict2["first name"]}");

            // Updating a value

            dict2["first name"] = "Geetha";
            Console.WriteLine($"Updating first name in dict2 : {dict2["first name"]}");

        }
    }
}

```
