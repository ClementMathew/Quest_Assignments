# Banking Application Using Linq

#### Question :

You are building a banking application with account and transaction records. Each transaction records a transfer between two accounts with details of the sender and receiver.

Entities:

    Account: Stores information about each bank account.
    Id: Unique identifier of the account.
    Name: Account holder's name.
    Balance: Current balance of the account.


    - Transact: Stores information about transactions.
        - Id: Unique identifier of the transaction.
        - FromId: Id of the account from which the amount is being transferred.
        - ToId: Id of the account to which the amount is being transferred.
        - Amount: Amount of money being transferred.
        - DayTime: Date and time of the transaction.

    Tasks:
    1. Use LINQ to list all transactions with details:
        - Transaction ID, From Account Name, To Account Name, Amount, Date of Transaction.

    2. Write extension methods to check if a given integer is even or odd.
        - `IsEven()` should return true if the number is even.
        - `IsOdd()` should return true if the number is odd.

---

#### Example Code :

```c#

```
