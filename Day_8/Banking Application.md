-- Creating Customer Table --

```sql
CREATE TABLE Customers (
customer_id INT IDENTITY(1,1) PRIMARY KEY,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
date_of_birth DATE,
email VARCHAR(100) UNIQUE,
phone_number VARCHAR(20),
address VARCHAR(255),
created_at DATETIME DEFAULT GETDATE()
);

CREATE INDEX customer_phone_indx
ON Customers (phone_number);

-- Creating Accounts Table --

CREATE TABLE Accounts (
account_id INT IDENTITY(1,1) PRIMARY KEY,
customer_id INT NOT NULL,
account_type VARCHAR(20) CHECK (account_type IN ('savings', 'credit')),
balance DECIMAL(15, 2) DEFAULT 0.00,
account_status VARCHAR(20) CHECK (account_status IN ('active', 'inactive', 'closed')) DEFAULT 'active',
created_at DATETIME DEFAULT GETDATE(),
CONSTRAINT FK_Customer_Account FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

-- Inserting values to Customers table --

INSERT INTO Customers (first_name, last_name, date_of_birth, email, phone_number, address)
VALUES
('Clement', 'Mathew', '2001-05-11', 'clement@mail.com', '1234567890', 'Kollam'),
('Mathew', 'Thomas', '1967-05-11', 'mathew@mail.com', '2234567890', 'Pathanamthitta');

-- Inserting values to Accounts table --

INSERT INTO Accounts (customer_id, account_type, balance)
VALUES
(2, 'savings', 5000.00),
(3, 'savings', 15000.00);

-- Delete an account --

DELETE FROM Accounts
WHERE account_id = 1;

-- Update account --

UPDATE Customers
SET first_name = 'Sheba',
last_name = 'Mathew'
FROM Accounts
INNER JOIN Customers ON Accounts.customer_id = Customers.customer_id
WHERE Accounts.account_id = 2;

UPDATE Accounts
SET account_type = 'credit'
WHERE account_id = 1;

-- Deposit money --

UPDATE Accounts
SET balance = balance + 2000.00
WHERE account_id = 2;

-- Withdraw money --

UPDATE Accounts
SET balance = balance - 2000.00
WHERE account_id = 2;

-- Transfer money --

CREATE TABLE Transactions (
transaction_id INT IDENTITY(1,1) PRIMARY KEY,
from_account_id INT NOT NULL,
to_account_id INT NOT NULL,
amount DECIMAL(15, 2) NOT NULL,
transfer_date DATETIME DEFAULT GETDATE(),
description VARCHAR(255),
CONSTRAINT FK_Transfer_FromAccount FOREIGN KEY (from_account_id) REFERENCES Accounts(account_id),
CONSTRAINT FK_Transfer_ToAccount FOREIGN KEY (to_account_id) REFERENCES Accounts(account_id)
);

INSERT INTO Transactions (from_account_id, to_account_id, amount, description)
VALUES (5, 6, 100.00, 'Happy Onam');

UPDATE Accounts
SET balance = balance - 100
WHERE account_id = 5;

UPDATE Accounts
SET balance = balance + 100
WHERE account_id = 6;

-- Transactions view --

SELECT
from_account_id AS sender,
to_account_id AS reciever,
amount,
transfer_date as [when]
FROM Transactions
```
