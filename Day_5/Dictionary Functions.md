# Dictionary Functions

#### Discussed about :

    All functions in Dictionary.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Functions
{
    internal class Dictionary_Functions
    {
        static void Main(string[] args)
        {
            // Dictionary functions.

            var dict = new Dictionary<string, string>();

            // Adding a new value.

            dict.Add("First Name", "Gatha");
            dict.Add("Last Name ", "Rekha");

            Console.WriteLine("After adding values to dict3 : ");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            // Removing a value

            dict.Remove("Last Name");

            Console.WriteLine("\nValues after Removing Last Name in dict3 : ");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();

            // Checking if the key exists using ContainsKey

            dict.Add("Age", "34");

            if (dict.ContainsKey("Age"))
            {
                Console.WriteLine("Contains Key : Age key exists");
            }
            else
            {
                Console.WriteLine("Contains Key : Key doesn't exist");
            }

            // Contains Value

            if (dict.ContainsValue("34"))
            {
                Console.WriteLine("Contains Value : Value exists");
            }
            else
            {
                Console.WriteLine("Contains Key : Value doesn't exist");
            }

            // Try Get Value

            Console.Write("\nTry Get Value : ");

            if (dict.TryGetValue("Age", out string value))
            {
                Console.WriteLine(value);
            }

            // Count

            int count = dict.Count;
            Console.WriteLine($"\nThe count of key value pairs in dict : {count}");

            // Keys

            ICollection<string> keys = dict.Keys;
            Console.WriteLine($"\nThe keys in dict : {string.Join(", ", keys)}");

            // Values

            ICollection<string> values = dict.Values;
            Console.WriteLine($"The values in dict : {string.Join(", ", values)}");

            // To Array

            KeyValuePair<string, string>[] array = dict.ToArray();
            Console.WriteLine($"\nThe array of key value pairs : {string.Join(" ", array)}");

            // Equals

            Dictionary<string, string> dict1 = new Dictionary<string, string> { { "1", "Apple" }, { "2", "Banana" } };
            Dictionary<string, string> dict2 = new Dictionary<string, string> { { "1", "Apple" }, { "2", "Banana" } };

            bool areEqual = dict1.Equals(dict2);
            Console.WriteLine($"\nChecking dict1 and dict2 are (Equals) : {areEqual}");

            // Element At

            KeyValuePair<string, string> element = dict.ElementAt(0);
            Console.WriteLine($"\nElement at 0 index : {element}");

            // Min and Max

            Dictionary<int, string> dict3 = new Dictionary<int, string> { { 1, "Banana" }, { 2, "Apple" }, { 3, "Cherry" } };

            var maxKey = dict3.Max(kvp => kvp.Key);
            var minValue = dict3.Min(kvp => kvp.Value);

            Console.WriteLine($"\nThe (Max) in Keys of dict : {maxKey}");
            Console.WriteLine($"The (Min) in Values of dict : {minValue}");

            // Clear

            dict.Clear();

            KeyValuePair<string, string>[] array2 = dict.ToArray();
            Console.WriteLine($"\nThe key value pairs after (Clear) : {string.Join(" ", array2)}");
        }
    }
}

```
