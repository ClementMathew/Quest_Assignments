# User Product and Orders

#### Question :

    1. Create user table.
    2. Alter table to add constraints.
    3. Create index.
    4. Add check constraints.

---

#### Code :

```sql

-- Creating User table --

CREATE TABLE users(
	id BIGINT IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	username VARCHAR(25) NOT NULL,
	email VARCHAR(100) NOT NULL,
	phone_number VARCHAR(20),
	dob DATETIME,
	password_hash VARCHAR(250),
	about TEXT
);

-- Altering the structure of table to Add Constraints --

ALTER TABLE users
ADD CONSTRAINT PK_user_id PRIMARY KEY (id);

ALTER TABLE users
ADD CONSTRAINT UQ_users_username UNIQUE (username)

ALTER TABLE users
ADD CONSTRAINT UQ_users_email UNIQUE (email)

-- Creating the index --

CREATE INDEX IX_users_phone
ON users (phone_number)

-- Adding Check Constraints --

ALTER TABLE users
ADD CONSTRAINT CHK_users_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20)

ALTER TABLE users
ADD CONSTRAINT CHK_users_dob CHECK (dob < GETDATE())

```
