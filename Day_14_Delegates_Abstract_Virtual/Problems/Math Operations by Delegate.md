# Math Operations by Delegate

#### Question :

    Define a delegate Operation that takes two integers as parameters and write methods Add and Multiply that match this delegate signature.

Demonstrate how to use the delegate to call these methods.

---

#### Code :

```c#

dusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    delegate int Operation(int x, int y);

    class Operations
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }

    internal class Math_Operations
    {
        static void Main(string[] args)
        {
            // Assigning the Add method to the delegate

            Operation op = Operations.Add;

            Console.WriteLine($"Addition: {op(5, 3)}");

            // Reassigning the Multiply method

            op = Operations.Multiply;

            Console.WriteLine($"Multiplication: {op(5, 3)}");

            // Reassigning the Subtract method

            op = Operations.Subtract;

            Console.WriteLine($"Subtraction: {op(5, 3)}");
        }
    }
}

```
