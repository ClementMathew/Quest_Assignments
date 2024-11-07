# Cart Management System

#### Question :

**Question:**

Create an E-Commerce Cart Management System in which principles of SOLID are followed in the design.

1. `CartManager` class for managing items in the cart.
2. `BillingService` class with an `IDiscountStrategy` dependency to calculate total amounts with discounts.
3. `IDiscountStrategy` interface for different discount strategies, such as `PercentageDiscountStrategy` and `FlatDiscountStrategy`.
4. `CartItem` class to represent each item in the cart, including properties for item name, quantity, price, and total price.

<br>

---

#### Code :

```c#

// ECommerce Cart Management System Class

using System;
using System.Collections.Generic;
using E_Commerce_Cart_Management_System.Discount_Strategy;
using E_Commerce_Cart_Management_System.Entities;

namespace E_Commerce_Cart_Management_System
{
    internal class Program
    {
        // class DiscountStrategy
        // {
        //     public decimal ApplyDiscount(decimal totalPrice, string strategy)
        //     {
        //         if (strategy == "percentage")
        //         {
        //             return totalPrice - (totalPrice * 2 / 100);
        //         }
        //         else if(strategy == "flat")
        //         {
        //             return totalPrice - 200;
        //         }
        //     }
        // }

        static void Main(string[] args)
        {
            CartManager cartManager = new CartManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- E-Commerce Cart Management System ---");

                Console.WriteLine("\n1. Add Item to Cart");
                Console.WriteLine("2. Remove Item from Cart");
                Console.WriteLine("3. View All Items in Cart");
                Console.WriteLine("4. Percentage Discount");
                Console.WriteLine("5. Exit");

                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        cartManager.Add(new CartItem { Name = name, Quantity = quantity });
                        Console.WriteLine("Item added successfully!");

                        break;

                    case "2":
                        Console.Write("Enter the product name to remove: ");
                        string productName = Console.ReadLine();

                        cartManager.Remove(productName);
                        Console.WriteLine("Item removed successfully!");

                        break;

                    case "3":
                        Console.WriteLine("Items in Cart:");
                        List<CartItem> items = cartManager.GetAll();

                        if (items.Count > 0)
                        {
                            foreach (CartItem item in items)
                            {
                                Console.WriteLine($"{item.Name} - Quantity: {item.Quantity}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cart is empty.");
                        }
                        break;

                    case "4":
                        cartManager.Add(new CartItem { Name = "Item 1", Price = 100, Quantity = 2 });
                        cartManager.Add(new CartItem { Name = "Item 2", Price = 200, Quantity = 3 });
                        cartManager.Add(new CartItem { Name = "Item 3", Price = 300, Quantity = 4 });

                        PercentageDiscountStrategy discountStrategy = new PercentageDiscountStrategy();
                        BillingService billingService = new BillingService(discountStrategy);

                        decimal totalAmount = billingService.CalculateTotalAmount(cartManager.GetAll());
                        Console.WriteLine($"Total amount: {totalAmount}");

                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting program...");

                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");

                        break;
                }
            }
        }
    }
}

```

```c#

// Cart Manager Class

using System.Collections.Generic;
using System.Linq;

namespace E_Commerce_Cart_Management_System.Entities
{
    class CartManager
    {
        private readonly List<CartItem> _items = new List<CartItem>();

        public void Add(CartItem item)
        {
            CartItem existingItem = _items.FirstOrDefault(i => i.Name == item.Name);

            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _items.Add(item);
            }
        }

        public void Remove(string productName)
        {
            _items.RemoveAll(i => i.Name == productName);
        }

        public List<CartItem> GetAll() => _items;
    }

}

```

```c#

// Billing Service Class

using System.Collections.Generic;
using System.Linq;
using E_Commerce_Cart_Management_System.Entities;
using E_Commerce_Cart_Management_System.Models;

namespace E_Commerce_Cart_Management_System
{
    public class BillingService
    {
        private readonly IDiscountStrategy _discountStrategy;

        public BillingService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotalAmount(List<CartItem> cartItems)
        {
            decimal totalAmount = cartItems.Sum(i => i.TotalPrice);
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }

}

```

```c#

// Discount Strategy Interface

namespace E_Commerce_Cart_Management_System.Models
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
}

```

```c#

// CartItem Class

namespace E_Commerce_Cart_Management_System.Entities
{
    public class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Price * Quantity;
    }
}

```

```c#

// Percentage Discount Strategy Interface

using E_Commerce_Cart_Management_System.Models;

namespace E_Commerce_Cart_Management_System.Discount_Strategy
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _discountPercentage = 2;

        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - (totalAmount * _discountPercentage / 100);
    }
}

```

```c#

// Flat Discount Strategy

using E_Commerce_Cart_Management_System.Models;

namespace E_Commerce_Cart_Management_System.Discount_Strategy
{
    public class FlatDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - 200;
    }
}

```
