# Credit Card Management System

#### Question :

Create a credit card application with functionalities :

    1. Add Credit Card
    2. Update Credit Card
    3. Search Credit Card
    4. Delete Credit Card

---

#### Code :

```c#

// Credit Card Management System Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_Management_System
{
    internal class Credit_Card_Management_System
    {
        static void Main(string[] args)
        {
            CreditCardManager cardManager = new CreditCardManager();

            // Add a card

            cardManager.AddCard("Clement", 1234567890, 256, "2025-08-09");
            cardManager.AddCard("Mathew", 2234567890, 356, "2026-08-09");

            // Searching for a card

            cardManager.SearchCard(1234567890);

            // Updating a card

            cardManager.UpdateCard(1234567890, "Sheba");

            // Deleting a card

            cardManager.DeleteCard(1234567890);
        }
    }
}
```

```c#

// Credit Card Manager Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_Management_System
{
    internal class CreditCardManager
    {
        private List<CreditCard> creditCards = new List<CreditCard>();

        public void AddCard(string name, long cardNumber, int cvv, string expiryDate)
        {
            CreditCard card = new CreditCard();

            card.Name = name;
            card.CardNumber = cardNumber;
            card.CVV = cvv;
            card.ExpiryDate = DateTime.Parse(expiryDate);

            creditCards.Add(card);
            Console.WriteLine("\nCard added successfully.");
        }

        public void UpdateCard(long cardNumber, string newHolderName)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    card.Name = newHolderName;

                    Console.WriteLine("\nCard updated successfully.");
                    return;
                }
            }
            Console.WriteLine("\nCard not found.");
        }

        public void DeleteCard(long cardNumber)
        {
            for (int i = 0; i < creditCards.Count; i++)
            {
                if (creditCards[i].CardNumber == cardNumber)
                {
                    creditCards.RemoveAt(i);
                    Console.WriteLine("\nCard deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("\nCard not found.");
        }

        public void SearchCard(long cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    card.DisplayCard();
                    return;
                }
            }
            Console.WriteLine("\nCard not found.");
        }
    }
}
```

```c#

// Credit Card Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_Management_System
{
    internal class CreditCard
    {
        public string Name;
        public long CardNumber;
        public int CVV;
        public DateTime ExpiryDate;

        public void DisplayCard()
        {
            Console.WriteLine($"\nThe credit card holder name is {Name}");
            Console.WriteLine($"\nThe credit card number is {CardNumber}");
            Console.WriteLine($"The CV number is {CVV}");
            Console.WriteLine($"The expiry date is {ExpiryDate}");
        }
    }
}
```
