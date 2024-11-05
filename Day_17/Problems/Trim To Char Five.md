# Trim To Char Five

#### Question :

Trim a string to five characters using the `TrimToFiveChars` method with the `ref` keyword, modifying the original `string`. Given `text = "Old Data"`, the output will be `"Old D..."`.

<br>

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim_To_Five_Char
{
    internal class Trim_To_Five_Char
    {
        static bool TrimToFiveChars(ref string data)
        {
            if (data.Length > 5)
            {
                data = data.Substring(0, 5);
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string text = "Old Data";

            if (TrimToFiveChars(ref text))
            {
                Console.WriteLine(text + "...");
            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}

```
