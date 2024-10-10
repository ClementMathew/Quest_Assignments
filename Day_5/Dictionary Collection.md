# Dictionary Collection

#### Discussed about :

    Dictionary functions like Add, Remove and ContainsKey.

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

            // Dictionary functions.

            var dict3 = new Dictionary<string, string>();

            // Adding a new value.

            dict3.Add("First Name", "Gatha");
            dict3.Add("Last Name ", "Regh");

            Console.WriteLine("After adding values to dict3 : ");

            foreach (var item in dict3)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();

            // Acessing a value.

            Console.WriteLine($"Accessing First Name in dict3 : {dict3["First Name"]}");

            // Updating a value

            dict3["First Name"] = "Geetha";
            Console.WriteLine($"Updating First Name in dict3 : {dict3["First Name"]}");

            // Removing a value

            dict3.Remove("Last Name");

            Console.WriteLine("\nValues after Removing Last Name in dict3 : ");

            foreach (var item in dict3)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();

            // Checking if the key exists using ContainsKey

            dict3.Add("Age", "34");

            if (dict3.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exists");
            }
            else
            {
                Console.WriteLine("Key doesn't exist");
            }

        }
    }
}

```
