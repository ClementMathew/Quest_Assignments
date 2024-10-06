# Digit to Words

##### Question :

    Convert the digit in the input string to equivalent words.

---

##### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_to_Words
{
    internal class Digit_to_Words
    {
        static void Main(string[] args)
        {
            // Changing digit to words

            string[] input = { "One", "2", "Three", "Four", "5" };

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case "1":
                        input[i] = "One";
                        break;

                    case "2":
                        input[i] = "Two";
                        break;

                    case "3":
                        input[i] = "Three";
                        break;

                    case "4":
                        input[i] = "Four";
                        break;

                    case "5":
                        input[i] = "Five";
                        break;

                    default:
                        break;
                }
                Console.WriteLine(input[i]);
            }
        }
    }
}

```
