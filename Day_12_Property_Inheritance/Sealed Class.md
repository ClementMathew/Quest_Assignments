# Sealed Class

#### Discussed about :

    Concept of Sealed Class.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_CLass
{
    sealed class Calculator
    {
        public int Add(int a, int b) => a + b;
    }

    // Trying to inherit from a sealed class will cause a compile-time error

    /*
    class AdvancedCalculator : Calculator
    {
        // This will give an error: 'Calculator' cannot be inherited because it is marked sealed.
    }
    */

    internal class Sealed_Class
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"Sum: {calc.Add(5, 3)}");
        }
    }
}

```
