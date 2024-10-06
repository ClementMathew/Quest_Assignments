# String Functions

##### Discussed about :

    Different built-in functions for string.

---

##### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    internal class String_Functions
    {
        static void Main(string[] args)
        {

            // String functions.

            string text = "    Hello World    ";

            // Case conversion.

            Console.WriteLine($"Converting to uppercase : {text.ToUpper()}");
            Console.WriteLine($"Converting to lowercase : {text.ToLower()} \n");

            // Trimming.

            Console.WriteLine($"Trimming extra spaces : {text.Trim()}");
            Console.WriteLine($"Trimming extra spaces from start : {text.TrimStart()}");
            Console.WriteLine($"Trimming extra spaces from end : {text.TrimEnd()} \n");

            // Replace and Remove.

            Console.WriteLine($"Replacing space with dash : {text.Replace(" ", "-")}");
            Console.WriteLine($"Removing letters from 0 to 7th index : {text.Remove(0, 7)} \n");

            // Length.

            Console.WriteLine($"Length of the string : {text.Length}");
            Console.WriteLine($"Length of string after trimming : {text.Trim().Length} \n");

            // Contains.

            Console.WriteLine($"Checking substring in the string : {text.Contains("Hello")} \n");

            // Startswith and Endswith.

            Console.WriteLine($"Checking starts with a substring : {text.StartsWith("    Hello")}");
            Console.WriteLine($"Checking starts with a substring without considering case : {text.StartsWith("    hello", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Checking endswith a substring : {text.EndsWith("    ")} \n");

            // Join.

            char[] chars = text.ToCharArray();
            Console.WriteLine($"Converting to char array : {string.Join(", ", chars)} \n");

            // Split.

            string[] words = text.Split(' ');
            Console.WriteLine($"Splitting the string with space : {string.Join(", ", words)} \n");

            string[] splits = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Splitting the string with space and removing empty strings : {string.Join(", ", splits)} \n");
        }
    }
}

```
