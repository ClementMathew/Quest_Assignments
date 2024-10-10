# Break and Continue

#### Discussed about :

    1. Break Keyword
    2. Continue Keyword

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_And_Continue
{
    internal class Break_And_Continue
    {
        static void Main(string[] args)
        {
            {

                // BREAK AND CONTINUE


                // Infinite Sum of Numbers.

                int sum = 0;

                while (true)
                {
                    Console.WriteLine("Enter the number to add or q to exit : ");
                    string data = Console.ReadLine();

                    if (data == "q")
                    {
                        break;
                    }
                    sum += int.Parse(data);

                    Console.WriteLine($"The sum till now is : {sum} \n");
                }


                // Sum of Numbers in Pattern.

                string pattern = "1_2_3";
                int result = 0;

                for (int i = 0; i < pattern.Length; i++)
                {
                    if (pattern[i] == '_')
                    {
                        continue;
                    }
                    result += int.Parse(pattern[i].ToString());
                }
                Console.WriteLine($"The sum of numbers in pattern {pattern} is {result}");
            }
        }
    }
}

```
