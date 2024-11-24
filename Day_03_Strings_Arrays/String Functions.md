# String Functions

#### Discussed about :

    Different built-in functions for string.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            Console.WriteLine($"Checking substring in the string : {text.Contains("Hello")}");

            // Equals.

            string text1 = "Hello";
            string text2 = "hello";
            bool isEqual = text1.Equals(text2);
            Console.WriteLine($"Checking {text1} and {text2} with Equals : {isEqual}\n");

            // Startswith and Endswith.

            Console.WriteLine($"Checking starts with a substring : {text.StartsWith("    Hello")}");
            Console.WriteLine($"Checking starts with a substring without considering case : {text.StartsWith("    hello", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Checking endswith a substring : {text.EndsWith("    ")} \n");

            // Join and ToChar Array.

            char[] chars = text.ToCharArray();
            Console.WriteLine($"Converting to char array : {string.Join("-", chars)} ");

            // Concat.

            string fullText = string.Concat(text1, " ", text2);
            Console.WriteLine($"\nConcatinating {text1} with {text2} with concat : {fullText}\n");

            // Split.

            string[] words = text.Split(' ');
            Console.WriteLine($"Splitting the string with space : {string.Join(",", words)} \n");

            string[] splits = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Splitting the string with space and removing empty strings : {string.Join(", ", splits)} \n");

            // Substring.

            string sub = text.Substring(5, 9);
            Console.WriteLine($"\nThe substring from 5 to 9 in '{text}' is '{sub}'");

            // IndexOf.

            int index = text.IndexOf('H');
            Console.WriteLine($"\nThe index of 'H' in '{text}' is {index}");

            // Last IndexOf.

            int lastIndex = text.LastIndexOf("o");
            Console.WriteLine($"The last index of 'o' in '{text}' is {lastIndex}");

            // Padleft and Padright

            string text3 = "Hello";
            string paddedR = text.PadRight(10);
            Console.WriteLine($"\nThe right padded of {text3} is {paddedR}");

            string paddedL = text.PadLeft(10);
            Console.WriteLine($"The left padded of {text3} is {paddedL}");

            // Format.

            string name = "John";
            int age = 30;
            string formattedString = string.Format("Name -> {0}, Age -> {1}", name, age);
            Console.WriteLine($"\nFormatted string : {formattedString}");
        }
    }
}

```
