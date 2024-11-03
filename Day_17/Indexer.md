# Indexer

#### Discussed about :

    Concept of Indexer

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;

namespace Indexer
{
    internal class Indexer
    {
        class ShoppingList
        {
            private List<string> _items = new List<string>();

            // Indexer to access items in the shopping list

            public string this[int index]
            {
                get
                {
                    if (index >= _items.Count)
                    {
                        throw new IndexOutOfRangeException("Index Out of Range");
                    }
                    return _items[index];
                }
                set
                {
                    if (index >= _items.Count)
                    {
                        _items.Add(value);
                    }
                    else
                    {
                        _items[index] = value;
                    }
                }
            }

            // Property to get the total count of items in the shopping list

            public int TotalItems => _items.Count;
        }

        static void Main(string[] args)
        {
            try
            {
                var shoppingList = new ShoppingList();

                // Accessing the total items count

                Console.WriteLine("Total items: " + shoppingList.TotalItems);

                // Example to add an item

                shoppingList[0] = "Apples";
                shoppingList[1] = "Oranges";

                Console.WriteLine("Total items after adding: " + shoppingList.TotalItems);

                // Accessing an item by index

                Console.WriteLine("Item at index 0: " + shoppingList[0]);

                // Next line will throw an IndexOutOfRangeException

                Console.WriteLine(shoppingList[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

```
