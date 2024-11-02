# Iteration Statements

#### Discussed about :

    1. for Loop Iteration Statement
    2. while Loop Iteration Statement

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Statements
{
    internal class Iteration_Statements
    {
        static void Main(string[] args)
        {

            // For loop statement.

            Console.Write("For loop : ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            // While loop statement.

            int n = 0;
            Console.Write("While loop : ");

            while (n < 5)
            {
                Console.Write(n + " ");
                n++;
            }
            Console.WriteLine("\n");


            // Foreach.

            var sb = new StringBuilder();
            string[] names = { "Clement", "Mathew", "Sheba" };

            for (int i = 0; i < names.Length; i++)
            {
                sb.AppendLine($"{names[i]} is {i} years old.");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

```
