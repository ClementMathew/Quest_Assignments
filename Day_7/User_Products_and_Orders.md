# User Product and Orders

#### Question :

    1. Create products and orders table.
    2. Create self refering table.
    3. Perform joins to retrieve necessary datas.
    4. Create view to see all orders.

#### Code :

```sql

-- Creating Products Table --

CREATE TABLE products(
    id BIGINT IDENTITY PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL CHECK (price > 0),
    stock_quantity INT NOT NULL DEFAULT 0 CHECK (stock_quantity >= 0),
    category_id INT NOT NULL,
    created_at DATETIME2 DEFAULT GETDATE(),
    updated_at DATETIME2 DEFAULT GETDATE()
);

-- Creating Orders Table --

CREATE TABLE orders(
	id BIGINT PRIMARY KEY IDENTITY,
	quantity INT NOT NULL DEFAULT 1,
	product_id BIGINT NOT NULL,
	user_id BIGINT NOT NULL,
	CONSTRAINT FK_orders_Product_id
	FOREIGN KEY(product_id) REFERENCES products(id),
	CONSTRAINT FK_orders_User_id
	FOREIGN KEY(user_id) REFERENCES users(id) ON DELETE CASCADE
);


-- Inserting values to users --

INSERT INTO users (first_name, last_name, username, email, phone_number, dob, password_hash, about)
VALUES
('Manu', 'Smith', 'manusmith', 'manu.smith@email.com', '1234567890', '1990-05-15', 'hashedPassword1', 'Loves tech and coding'),
('Ethan', 'Davis', 'ethdavis', 'ethan.davis@email.com', '3216549870', '1995-03-25', 'hashedPassword5', 'Creative designer and developer');


-- Inserting values to products --

INSERT INTO products (name, description, price, stock_quantity, category_id)
VALUES
('Laptop', 'High-end gaming laptop', 1200.00, 50, 1),
('Monitor', '27-inch 4K Ultra HD monitor', 299.99, 75, 5);


-- Inserting values to orders --

INSERT INTO orders (quantity, product_id, user_id)
VALUES
(2, 1, 1),
(1, 2, 2);


-- Self refering table --

CREATE TABLE employees(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR (50),
	email VARCHAR (100),
	manager_id INT,
	CONSTRAINT fk_foo_boo
	FOREIGN KEY(manager_id) REFERENCES employees(id)
 );


 -- Tables using many to many relations --

 CREATE TABLE category(
	id BIGINT PRIMARY KEY IDENTITY,
	name VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE product_categories(
	id INT PRIMARY KEY IDENTITY,
	category_id BIGINT,
	product_id BIGINT,
	CONSTRAINT fk_category_id FOREIGN KEY(category_id) REFERENCES category(id),
	CONSTRAINT fk_product_id FOREIGN KEY(product_id) REFERENCES products(id)
);


-- Inserting values to category --

INSERT INTO category (name) VALUES ('home'),('electronics');

-- Inserting values to product_categories --

INSERT INTO product_categories (category_id,product_id) VALUES (2,1),(1,1);


-- Joins --

SELECT orders.id AS order_id,
       products.id AS product_id,
       products.name AS product_name,
       products.price AS price,
       users.id AS user_id,
       users.first_name AS user_name
FROM Orders
INNER JOIN Products ON orders.product_id = products.id
INNER JOIN Users ON orders.user_id = users.id;

-- Right join to fetch products even if there are no orders

SELECT orders.id AS order_id,
       orders.quantity,
       products.id AS product_id,
       products.name AS product_name,
       products.price AS price
FROM Orders
RIGHT JOIN Products ON orders.product_id = products.id;

-- Left join to fetch orders even if there are no matching products

SELECT orders.id AS order_id,
       orders.quantity,
       products.id AS product_id,
       products.name AS product_name,
       products.price AS price
FROM Orders
LEFT JOIN Products ON orders.product_id = products.id;

-- Left join with inner join to fetch orders, products, and user details

SELECT orders.id AS order_id,
       orders.quantity,
       products.id AS product_id,
       products.name AS product_name,
       products.price AS price,
       users.first_name,
       users.last_name
FROM Orders
LEFT JOIN Products ON orders.product_id = products.id
INNER JOIN Users ON orders.user_id = users.id;


-- Create view to select all from Orders

CREATE VIEW view_orders
AS
SELECT * FROM Orders;

```
