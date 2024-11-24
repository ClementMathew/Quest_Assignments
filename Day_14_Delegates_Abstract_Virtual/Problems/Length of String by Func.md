# Length of String by Func

#### Question :

    Write a Func<string, int> delegate that takes a string as input and returns the length of the string.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_String
{
    internal class Length_of_String
    {
        static void Main(string[] args)
        {
            Func<string, int> lengthFunc = s => s.Length;

            Console.WriteLine(lengthFunc("Hello World!"));
        }
    }
}

```
