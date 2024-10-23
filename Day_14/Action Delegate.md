# Action Delegate

#### Discussed about :

    Concept of Action Delegate.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate
{
    internal class Action_Delegate
    {
        // Static method to greet

        static void Greet()
        {
            Console.WriteLine("Hello!");
        }

        // Static method to greet with a custom message

        static void GreetWithMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Static method to add two numbers

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            // Action delegate pointing to Greet method

            Action greet = Greet;

            // Action delegate that takes a string parameter

            Action<string> greetMessage = GreetWithMessage;

            // Action delegate that takes two integer parameters

            Action<int, int> add = Add;

            // Invoking the delegates

            greet();
            greetMessage("Hello from a delegate!");
            add(1, 2);
        }
    }
}

```
