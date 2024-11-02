# Conditional Statements

#### Discussed about :

    1. if-else Conditional Statements
    2. switch-case Conditional Statements

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Conditional_Statements
    {
        static void Main(string[] args)
        {

            // IF-ELSE CONDITIONAL STATEMENTS


            // License Minimum Age.

            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("You can drive.");
            }
            if (!(age < 18))
            {
                Console.WriteLine("Yes, you can drive.");
            }

            Console.WriteLine();


            // Grading System.

            Console.WriteLine("Enter the mark : ");
            int mark = int.Parse(Console.ReadLine());

            if (mark >= 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (mark >= 80 && mark < 90)
            {
                Console.WriteLine("B Grade");
            }
            else if (mark >= 70 && mark < 80)
            {
                Console.WriteLine("C Grade");
            }
            else if (mark >= 60 && mark < 70)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("F Grade");
            }

            Console.WriteLine();



            // SWITCH CASE CONDITIONAL STATEMENTS


            // Weekday Number to Weekday Name.

            int day = 4;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Day 1 is Monday");
                    break;

                case 2:
                    Console.WriteLine("Day 2 is Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Day 3 is Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Day 4 is Thursday");
                    break;

                case 5:
                    Console.WriteLine("Day 5 is Friday");
                    break;

                case 6:
                    Console.WriteLine("Day 6 is Saturday");
                    break;

                case 7:
                    Console.WriteLine("Day 7 is Sunday");
                    break;

                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
        }
    }
}

```
