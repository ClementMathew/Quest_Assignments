# Database Relationships

There are three primary types of relationships in DBMS. In each type of relationship plays a unique role in database design.

    1. One-to-One relationship
    2. One-to-Many or Many-to-One relationship
    3. Many-to-Many relationship

#### One to One Relationship

---

- In one-to-one relationship a single record in one table is related with a single record in other table and vice versa.
  This type of relationships are relatively rare and commonly used for security or organizational reasons.

- In one to one relationships, a record is present in one table along with its corresponding existing relation, and the vacant relation among the records is present in another table.

- The type of relationship we are talking about is not as usual, and it is normally used when two entities that belong to a specific set need to be stored independently for normalization or security purposes.

<br>

#### One to Many Relationship

---

- In one-to-many or many-to-one relationship, a single record in one table can be associated with multiple records in another table and this is the most common type of relationship in DBMS.

- A relationship where the items from one table can be linked to only one or many items from another table is called a one-to-many relationship.

- In some cases, one item from the first table correlates with only one item from the second table. This connection becomes very strong in that it is particularly used to describe situations where one object can be linked to many similar or identical objects.

- For example, in an online store backend database, every customer may place multiple orders, yet the master customer record stays the same.

<br>

#### One to Many Relationship

---

- A many-to-many relationship is relationship in which one multiple records in one table are associated with multiple records in another table.

- This relationship is mainly implemented using junction table.

- The duality of a many-to-many relationship is characterized by the presence of multiple records belonging to a table in association with multiple records from another table.

- The interconnection of these relationships follows a junction table format, which is the component that holds both tables together.

- In the many-to-many relationship model, a wide variety of complex relationships can be established where each entity has many related entities.

<br>
<br>

# Foreign Keys

Foreign keys are a set of constraints in DBMS that establish relationships between tables and also ensure consistency and integrity of data.

A foreign key is applied to a column of one table which references the primary key of a column in another table.

Note that it is mandatory that the other column must have a primary key as it references the data that is related in different tables and creates a relational structure. Foreign key enforces referential integrity and makes sure that data is referenced from one table to table.

A primary key is used to ensure data in the specific column is unique. A foreign key is a column or group of columns in a relational database table that provides a link between data in two tables.

<br>

#### Referential integrity constraints :

---

It can be specified between two tables. In case of referential integrity constraints, if a Foreign key in Table 1 refers to Primary key of Table 2 then every value of the Foreign key in Table 1 must be null or available in Table 2.

<br>

#### Foreign Keys and How They Establish Relationships :

---

<br>

- <b>One-to-One (1:1) Relationship : </b> Foreign Key can exist in either table to establish the relationship.

- <b> One-to-Many (1) or Many-to-One (M:1) Relationship : </b> Foreign Key present in the "many" table (Table B for 1, Table A for M:1) to reference the primary key in the other table.

- <b>Many-to-Many (M) Relationship :</b> Foreign Key is implemented using a junction table, where foreign keys reference both Table A and Table B.
