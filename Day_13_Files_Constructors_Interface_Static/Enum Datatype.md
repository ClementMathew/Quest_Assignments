# Enum Datatype

#### Discussed about :

    Enum Datatype.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Datatype
{
    internal class Enum_Datatype
    {
        public enum ConvertTo
        {
            UpperCase,
            LowerCase
        }

        public static void ConvertCasing(string input, ConvertTo targetType)
        {

            switch (targetType)
            {
                case ConvertTo.UpperCase:
                    Console.WriteLine(input.ToUpper());
                    break;

                case ConvertTo.LowerCase:
                    Console.WriteLine(input.ToLower());
                    break;
            }
        }

        static void Main()
        {
            ConvertCasing("Hello", ConvertTo.LowerCase);
            ConvertCasing("Hello", ConvertTo.UpperCase);
        }
    }
}

```
