# Welcome Message by Action

#### Question :

    Define an Action<string> delegate that prints a string to the console and use this delegate to call a method that prints a welcome message.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_Message
{
    internal class Welcome_Message
    {
        static void Main(string[] args)
        {
            Action<string> printAction = message => Console.WriteLine(message);

            printAction("Welcome to C# World!");
        }
    }
}

```
