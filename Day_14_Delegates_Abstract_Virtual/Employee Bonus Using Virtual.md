# Employee Bonus Using Virtual

#### Discussed about :

- Create a base class Employee with a virtual method CalculateBonus() and in the derived class Manager, override CalculateBonus() to provide a custom calculation.

```
  Concept of Virtual.
```

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Bonus
{
    class Employee
    {
        public virtual double CalculateBonus()
        {
            return 1000; // Default bonus
        }
    }

    class Manager : Employee
    {
        public override double CalculateBonus()
        {
            return 5000; // Manager bonus
        }
    }
    internal class Employee_Bonus
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Manager mgr = new Manager();

            Console.WriteLine("Employee bonus: " + emp.CalculateBonus());
            Console.WriteLine("Manager bonus: " + mgr.CalculateBonus());
        }
    }
}

```
