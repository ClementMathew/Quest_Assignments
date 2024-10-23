# Calculator Using Interface

#### Question :

    Write an interface ICalculator that has methods Add(int a, int b) and Subtract(int a, int b) and implement this interface in a SimpleCalculator class.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Using_Interface
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    internal class Calculator_Using_Interface
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new SimpleCalculator();

            int resultAdd = calculator.Add(5, 3);
            int resultSubtract = calculator.Subtract(10, 4);

            Console.WriteLine($"Addition: {resultAdd}");
            Console.WriteLine($"Subtraction: {resultSubtract}");
        }
    }
}

```
