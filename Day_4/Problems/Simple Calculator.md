# Simple Calculator

#### Question :

    Create a simple calculator with all basic arithmetic operations.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Simple_Calculator
    {

        // Calculator

        static void Addition(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }
        static void Subtraction(int a, int b)
        {
            Console.WriteLine($"The difference of {a} and {b} is {a - b}");
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine($"The product of {a} and {b} is {a * b}");
        }
        static void Division(float a, float b)
        {
            Console.WriteLine($"The fraction of {a} and {b} is {a / b}");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEnter the first number : ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operator : ");
                string op = Console.ReadLine();

                if (op == "+")
                {
                    Addition(a, b);
                }
                if (op == "-")
                {
                    Subtraction(a, b);
                }
                if (op == "*")
                {
                    Multiplication(a, b);
                }
                if (op == "/")
                {
                    Division(a, b);
                }
            }
        }
    }
}

```
