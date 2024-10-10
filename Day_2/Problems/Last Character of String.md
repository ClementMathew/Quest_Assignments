# Last Character of String

#### Question :

Print the last character of the input string.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Character_of_String
{
    internal class Last_Character_of_String
    {
        static void Main(string[] args)
        {
            string s = "Hello";

            char lastChar = s[s.Length-1];

            Console.WriteLine($"Last character of {s} is '{lastChar}'");
        }
    }
}

```
