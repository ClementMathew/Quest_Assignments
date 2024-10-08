# Object and Type

##### Discussed about :

    1. Object datatype
    2. Gettype and typeof functions
    3. Type datatype

---

##### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_Type
{
    internal class Object_and_Type
    {
        // Object datatype.

        static void DoThis(object a, object b)
        {
            if (a.GetType() == typeof(string))
            {
                string s1 = (string)a;
                string s2 = (string)b;

                Console.WriteLine(s1 + " " + s2);
            }
            else if (a.GetType() == typeof(int))
            {
                int i1 = (int)a;
                int i2 = (int)b;

                Console.WriteLine(i1 + i2);
            }
        }

        static void Main(string[] args)
        {
            DoThis(1, 2);
            DoThis("Hello", "World");

            // Type datatype.

            int x = 1;

            Type t1 = x.GetType();
            Type t2 = typeof(string);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}

```
