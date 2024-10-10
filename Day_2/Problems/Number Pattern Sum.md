# Number Pattern Sum

#### Question :

    Calculate the sum of numbers in the input string pattern.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pattern_Sum
{
    internal class Number_Pattern_Sum
    {
        static void Main(string[] args)
        {
            // Single Digit Number Pattern Summation.

            string pattern = "1_2_3_1";
            int sum = 0;
            int i = 0;

            while (i < pattern.Length)
            {
                sum += int.Parse(pattern[i].ToString());
                i = i + 2;
            }
            Console.WriteLine($"The sum of numbers in pattern {pattern} is {sum} \n");


            // Multiple Digit Number Pattern Summation.

            string patternMultiple = "10_200_3_1";
            int result = 0;
            int j = 0;
            string temp = "";

            for ( ; j < patternMultiple.Length ; j++)
            {
                if (patternMultiple[j] == '_')
                {
                    result += int.Parse(temp);
                    temp = "";
                    continue;
                }
                else
                {
                    temp += patternMultiple[j];
                }
                if (patternMultiple.Length == (j + 1))
                {
                    result += int.Parse(temp);
                }
            }
            Console.WriteLine($"The sum of numbers in pattern {patternMultiple} is {result} \n");
        }
    }
}

```
