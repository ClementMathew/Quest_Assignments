# Credit Card From User

#### Question :

Create a credit card for user by reading :

    1. Credit Card Number
    2. CVV Number
    3. Expiry Date

---

#### Code :

```c#

// Credit Card User

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_From_User
{
    internal class Credit_Card_From_User
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard();

            Console.WriteLine("Enter the credit card number : ");
            card.CardNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CVV number : ");
            card.CVV = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the expiry date (YYYY-MM-DD) : ");
            card.ExpiryDate = DateTime.Parse(Console.ReadLine());

            card.DisplayCardDetails();

            Console.WriteLine(card);
        }
    }
}

```

```c#

// Credit Card

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_From_User
{
    internal class CreditCard
    {
        public string Name;
        public long CardNumber;
        public int CVV;
        public DateTime ExpiryDate;

        public void DisplayCardDetails()
        {
            Console.WriteLine($"\nThe credit card number is {CardNumber}");
            Console.WriteLine($"The CVV number is {CVV}");
            Console.WriteLine($"The expiry date is {ExpiryDate}");
        }

        public override string ToString()
        {
            return $"\nThe credit card {CardNumber} with CVV number {CVV} will expire in {ExpiryDate}";
        }
    }

}

```
