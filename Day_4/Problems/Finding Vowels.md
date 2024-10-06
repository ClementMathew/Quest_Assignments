# Finding Vowels

##### Question :

Print the vowels from an input string.

---

##### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_Vowels
{
    internal class Finding_Vowels
    {
        static void Main(string[] args)
        {

            // Printing Vowels

            string textInput = "Clement";
            string vowels = "aeiou";

            foreach (var item in textInput)
            {
                if (vowels.Contains(item.ToString().ToLower()))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

```
