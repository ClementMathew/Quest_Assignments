# Partial Class

#### Question :

    Concept of Partial Class.

---

#### Code :

```c#

// Partial Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    internal class Partial_Class
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.ProductName = "Laptop";
            product.ProductID = "P001";
            product.Price = 1200.99m;
            product.StockQuantity = 30;

            product.DisplayBasicInfo();
            product.DisplayPricingInfo();
        }
    }
}

```

```c#

// Partial Class Part 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class Product
    {
        public string ProductName { get; set; }
        public string ProductID { get; set; }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Product Name: {ProductName}, Product ID: {ProductID}");
        }
    }
}

```

```c#

// Partial Class Part 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class Product
    {
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public void DisplayPricingInfo()
        {
            Console.WriteLine($"Price: {Price}, Stock Quantity: {StockQuantity}");
        }
    }
}

```
