# Simple Calculator Using OOPS

#### Question :

Create a calculator with basic operations :

    1. Add two values
    2. Subtract two values
    3. Multiply two values
    4. Divide two values

---

#### Code :

```c#

// Calculator Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Using_OOPS
{
    internal class Simple_Calculator_Using_OOPS
    {
        static void Main(string[] args)
        {
            Calculator_Operations operation1 = new Calculator_Operations()
            {
                Operator1 = 5,
                Operator2 = 6,
            };

            operation1.Add();
            operation1.Subtract();
            operation1.Multiply();
            operation1.Division();
        }
    }
}


```

```c#

// Calculator Operations Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Using_OOPS
{
    internal class Calculator_Operations
    {
        public double Operator1;
        public double Operator2;

        public void Add() => Console.WriteLine($"The sum of {Operator1} and {Operator2} is {Operator1 + Operator2}");

        public void Subtract() => Console.WriteLine($"The difference of {Operator1} and {Operator2} is {Operator1 - Operator2}");

        public void Multiply() => Console.WriteLine($"The product of {Operator1} and {Operator2} is {Operator1 * Operator2}");

        public void Division() => Console.WriteLine($"The fraction of {Operator1} and {Operator2} is {Operator1 / Operator2}");
    }
}

```
