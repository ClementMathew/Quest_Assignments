# Show Message by Delegate

#### Question :

    Create a delegate PrintMessage that takes a string as a parameter and write a method DisplayMessage that prints the string passed to it.

Use the delegate to call DisplayMessage.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Message
{
    delegate void PrintMessage(string message);

    class Show_Message
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main()
        {
            PrintMessage print = DisplayMessage;

            print("Hello from the delegate!");
        }
    }
}

```
