```sql
--- USER TABLE AND ALTERING----
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

ALTER TABLE users
ADD CONSTRAINT PK_user_id PRIMARY KEY(id);

ALTER TABLE users
ADD CONSTRAINT UQ_users_username UNIQUE (username)

ALTER TABLE users
ADD CONSTRAINT UQ_users_email UNIQUE (email)

CREATE INDEX IX_users_phone
ON users (phone_number)

ALTER TABLE users
ADD CONSTRAINT CHK_users_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20)

ALTER TABLE users
ADD CONSTRAINT CHK_users_dob CHECK (dob < GETDATE())

----PRODUCTS TABLE---
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
----orders table--
CREATE TABLE Orders(

  id BIGINT PRIMARY KEY IDENTITY,
  quantity INT NOT NULL DEFAULT 1,
  product_id BIGINT NOT NULL,
  user_id BIGINT NOT NULL,

  CONSTRAINT FK_orders_Product_id
  FOREIGN KEY(product_id) REFERENCES products(id),

  CONSTRAINT FK_orders_User_id
  FOREIGN KEY(user_id) REFERENCES users(id) ON DELETE CASCADE
);
---INSERT AND SEE THE FORIEGN KEY REFERENCES ISSUES----
INSERT INTO users (first_name, last_name, username, email, phone_number, dob, password_hash, about)
VALUES
('Manu', 'Smith', 'manusmith', 'manu.smith@email.com', '1234567890', '1990-05-15', 'hashedPassword1', 'Loves tech and coding'),
('Sachu', 'Johnson', 'sachujohn', 'sachu.john@email.com', '9876543210', '1988-11-20', 'hashedPassword2', 'Avid reader and musician'),
('Midhun', 'Brown', 'midhbrown', 'midh.brown@email.com', '4567891230', '1992-07-07', 'hashedPassword3', 'Passionate about AI and robotics'),
('Vibhav', 'Williams', 'vibhwills', 'vibh.wills@email.com', '7891234560', '1985-02-10', 'hashedPassword4', 'Enjoys hiking and traveling'),
('Ethan', 'Davis', 'ethdavis', 'ethan.davis@email.com', '3216549870', '1995-03-25', 'hashedPassword5', 'Creative designer and developer');
INSERT INTO products (name, description, price, stock_quantity, category_id)
VALUES
('Laptop', 'High-end gaming laptop', 1200.00, 50, 1),
('Smartphone', 'Latest model smartphone with advanced features', 799.99, 150, 2),
('Headphones', 'Wireless noise-canceling headphones', 199.50, 300, 3),
('Keyboard', 'Mechanical keyboard with RGB lights', 99.99, 120, 4),
('Monitor', '27-inch 4K Ultra HD monitor', 299.99, 75, 5);
INSERT INTO products (name, description, price, stock_quantity, category_id)
VALUES
('Gaming Mouse', 'Ergonomic wireless gaming mouse with customizable buttons', 49.99, 200, 6),
('Tablet', '10-inch tablet with high-resolution display and 128GB storage', 399.99, 80, 7),
('Smartwatch', 'Smartwatch with fitness tracking and heart-rate monitor', 149.99, 250, 8);

INSERT INTO Orders (quantity, product_id, user_id)
VALUES
(2, 1, 1),  -- Manu orders 2 laptops
(1, 2, 2),  -- Sachu orders 1 smartphone
(3, 3, 3),  -- Midhun orders 3 headphones
(1, 4, 4),  -- Vibhav orders 1 keyboard
(1, 5, 5);  -- Ethan orders 1 monitor



---SELF REFERING--- ON DELETE SET NULL---

CREATE TABLE employees(

   id int primary key IDENTITY,
   name varchar(50),
   email varchar (100),
   manager_id int,
   constraint fk_foo_boo
   foreign key(manager_id) REFERENCES EMPLOYEES(ID)

 );
 --------MANY TO MANY---
 CREATE TABLE category(

  id bigint primary key identity,
  name varchar(100) unique not null

);


create table product_categories(
  id int primary key identity,
  category_id bigint,
  product_id bigint,

  constraint fk_category_id foreign key(category_id) references category(id),
  constraint fk_product_id foreign key(product_id) references products(id)

);

insert into product_categories values(2,1),(3,1),(2,2),(3,2)


----joins---
select orders.id as order_id,
      products.id as product_id,
	  products.name as product_name,
	  products.price as price,
	  users.id as  user_id,
	  users.first_name as user_name
	  from orders inner join products on orders.product_id = products.id inner join Users on orders.User_id = users.id ;
	  ---left join--
select orders.id as order_id,
      orders.quantity,
      products.id as product_id,
	  products.name as product_name,
	  products.price as price
	  from orders right join
	  products on orders.product_id= products.id;


select orders.id as order_id,
      orders.quantity,
      products.id as product_id,
	  products.name as product_name,
	  products.price as price
	  from orders left join
	  products on orders.product_id= products.id;

select orders.id as order_id,
      orders.quantity,
      products.id as product_id,
	  products.name as product_name,
	  products.price as price,
	  users.first_name,
	  users.last_name
	  from orders left join
	  products on orders.product_id= products.id inner join users on orders.user_id = users.id ;
	  ----create view---
CREATE VIEW view_Orders
AS
    SELECT * FROM ORDERS;

```
