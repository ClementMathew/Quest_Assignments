# Smartphone Models

#### Question :

Create a class `Smartphone` with properties for `Name`, `Manufacturer`, and a list of `RamSizes`.

Write a method `ShowModels()` that displays these details.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_Models
{
    class Smartphone
    {
        public string Name;
        public string Manufacturer;
        public List<string> RamSizes;

        public void ShowModels()
        {
            Console.WriteLine($"\nName : {Name}");
            Console.WriteLine($"Manufacturer : {Manufacturer}");
            Console.Write($"Ram Sizes : ");

            foreach (var item in RamSizes)
            {
                Console.Write(item + " GB ");
            }
            Console.WriteLine();
        }
    }

    internal class Smartphone_Models
    {
        static void Main(string[] args)
        {
            Smartphone p = new Smartphone();
            p.Name = "iPhone 16";
            p.Manufacturer = "Apple";
            p.RamSizes = new List<string>() { "8", "16" };

            p.ShowModels();

            Smartphone p2 = new Smartphone();
            p.Name = "iPhone 15";
            p.Manufacturer = "Apple";
            p.RamSizes = new List<string>() { "16", "32" };

            p.ShowModels();
        }
    }
}

```
