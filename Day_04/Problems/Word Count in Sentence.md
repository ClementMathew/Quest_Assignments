# Word Count in Sentence

#### Question :

    Count the number of same words in the input string.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Count_in_Sentence
{
    internal class Word_Count_in_Sentence
    {
        static void Main(string[] args)
        {
            // Count of words in a sentence.

            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();

            string[] arr = str.Split(' ');
            string[] counter = new string[arr.Length];
            int counterIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (counter.Contains(arr[i]))
                {
                    continue;
                }
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        counter[counterIndex] = arr[i];
                        counterIndex++;
                    }
                }
                Console.WriteLine(arr[i] + ":" + count);
            }
        }
    }
}

```
