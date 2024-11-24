# Infinite Students Marks With Search

#### Question :

    User wants to store the marks of 3 subjects until the user enters 'q' to exit. 
    
    When user enters 'q' display the mark of subjects student wise and also enables a search option to find the id and its values.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Students_Mark_With_Search
{
    internal class Infinite_Students_Mark_With_Search
    {
        static void Main(string[] args)
        {
            var datas = new Dictionary<string, List<int>>();

            while (true)
            {
                Console.Write("Enter the student id to enter or q to exit : ");
                string id = (Console.ReadLine());

                if (id == "q")
                {
                    break;
                }
                else
                {
                    if (datas.ContainsKey(id))
                    {
                        Console.Write("Do you want to keep the marks of the existing id ? (Y/N) : ");
                        string c = Console.ReadLine().Trim().ToLower();

                        if (c == "y")
                        {
                            continue;
                        }
                    }
                    var marks = new List<int>();

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write($"Enter the mark for subject {j} : ");
                        marks.Add(int.Parse(Console.ReadLine()));
                    }
                    datas[id] = marks;
                }
            }
            Console.WriteLine();

            // displaying them

            foreach (var item in datas)
            {
                Console.Write($"The mark of student id {item.Key}:");

                foreach (var mark in item.Value)
                {
                    Console.Write($" {mark} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // searching using an id

            Console.Write("Enter the id to search : ");
            string ids = Console.ReadLine();

            if (datas.ContainsKey(ids))
            {
                Console.Write($"The mark of student {ids} :");
                foreach (var item in datas[ids])
                {
                    Console.Write($" {item} ");
                }
            }

            Console.ReadKey();
        }
    }
}

```
