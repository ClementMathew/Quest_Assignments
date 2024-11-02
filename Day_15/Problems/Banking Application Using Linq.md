# Banking Application Using Linq

#### Question :

You are building a banking application that manages account and transaction records. Each transaction records a transfer between two accounts, detailing the sender and receiver information.

---

#### Entities :

- **Account** : Stores information about each bank account.

  - **Id**: Unique identifier of the account.
  - **Name**: Name of the account holder.
  - **Balance**: Current balance of the account.

<br>

- **Transact** : Stores information about transactions.

  - **Id**: Unique identifier of the transaction.
  - **FromId**: Id of the account from which the amount is being transferred.
  - **ToId**: Id of the account receiving the amount.
  - **Amount**: The amount of money being transferred.
  - **DayTime**: Date and time of the transaction.

<br>

---

#### Tasks :

1. **List Transaction Details with LINQ**

   Use LINQ to list all transactions, displaying :

   - **Transaction ID**
   - **From Account Name**
   - **To Account Name**
   - **Amount**
   - **Date of Transaction**

<br>

2. **Extension Methods**

   Create extension methods to check if an integer is even or odd.

   - **IsEven()**: Returns `true` if the number is even.
   - **IsOdd()**: Returns `true` if the number is odd.

<br>

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;

namespace Banking_Application_Using_Linq
{
    internal class Banking_Application_Using_Linq
    {
        static void Main(string[] args)
        {
            var account = new List<Account>()
            {
                new Account{Id = 1, Name = "Gatha", Balance = 1900},
                new Account{Id = 2, Name = "Minnu", Balance = 2000},
                new Account{Id = 3, Name = "Manu", Balance = 35000},
                new Account{Id = 4, Name = "Midhun", Balance = 5900}
            };

            var transact = new List<Transact>()
            {
                new Transact{Id = 100, FromId = 1, ToId = 2, Amount = 1000, DayTime = DateTime.Now},
                new Transact{Id = 101, FromId = 3, ToId = 4, Amount = 500, DayTime = DateTime.Now}
            };

            // Task 1: List all transactions with details:
            // Transaction ID, From Account Name, To Account Name, Amount, and Date of Transaction.

            var queryTransactions = from transaction in transact
                                    join fromAccount in account on transaction.FromId equals fromAccount.Id
                                    join toAccount in account on transaction.ToId equals toAccount.Id
                                    select new
                                    {
                                        TransactionId = transaction.Id,
                                        FromAccountName = fromAccount.Name,
                                        ToAccountName = toAccount.Name,
                                        Amount = transaction.Amount,
                                        Date = transaction.DayTime
                                    };

            Console.WriteLine("Transactions (Query Syntax):");
            foreach (var item in queryTransactions)
            {
                Console.WriteLine($"Transaction ID: {item.TransactionId}, From: {item.FromAccountName} To: {item.ToAccountName}, Amount: {item.Amount}, Date: {item.Date}");
            }

            // Task 1 (alternative): List all transactions with details:
            // Transaction ID, From Account Name, To Account Name, Amount, and Date of Transaction.

            var methodTransactions = transact
                .Join(account,
                      t => t.FromId,
                      a => a.Id,
                      (transaction, fromAccount) => new { transaction, fromAccount })
                .Join(account,
                      result => result.transaction.ToId,
                      toAccount => toAccount.Id,
                      (result, toAccount) => new
                      {
                          TransactionId = result.transaction.Id,
                          FromAccountName = result.fromAccount.Name,
                          ToAccountName = toAccount.Name,
                          Amount = result.transaction.Amount,
                          Date = result.transaction.DayTime
                      });

            Console.WriteLine("\nTransactions (Method Syntax):");
            foreach (var item in methodTransactions)
            {
                Console.WriteLine($"Transaction ID: {item.TransactionId}, From: {item.FromAccountName} To: {item.ToAccountName}, Amount: {item.Amount}, Date: {item.Date}");
            }

            // Task 2: Extension method to check if a number is even

            int data = 12;
            Console.WriteLine($"\nIs {data} Even? {data.IsEven()}");

            // Task 2: Extension method to check if a number is odd

            Console.WriteLine($"Is {data} Odd? {data.IsOdd()}");
        }
    }

    internal static class Methods
    {
        // Task 2: Method to check if a given integer is even

        public static bool IsEven(this int num) => num % 2 == 0;

        // Task 2: Method to check if a given integer is odd

        public static bool IsOdd(this int num) => num % 2 != 0;
    }

    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
    }

    class Transact
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public int Amount { get; set; }
        public DateTime DayTime { get; set; }
    }
}

```
