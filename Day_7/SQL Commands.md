# DDL Commands :

DDL or Data Definition Language actually consists of the SQL commands that can be used to define the database schema. It simply deals with descriptions of the database schema and is used to create and modify the structure of database objects in the database.
DDL is a set of SQL commands used to create, modify, and delete database structures but not data.

#### CREATE :

---

Create database or its objects (table, index, function, views, store procedure, and triggers).

```sql
CREATE TABLE table_name (column1 data_type, column2 data_type, ...);
```

#### ALTER :

---

Alter the structure of the database.

```sql
ALTER TABLE table_name ADD COLUMN column_name data_type;
```

#### TRUNCATE :

---

Remove all records from a table, including all spaces allocated for the records are removed.

```sql
TRUNCATE TABLE table_name;
```

#### DROP :

---

Delete objects from the database.

```sql
DROP TABLE table_name;
```

<br>
<br>

# DML Commands :

The SQL commands that deal with the manipulation of data present in the database belong to DML or Data Manipulation Language and this includes most of the SQL statements.
It is the component of the SQL statement that controls access to data and to the database.

#### INSERT :

---

Insert data into a table.

```sql
INSERT INTO table_name (column1, column2, ...) VALUES (value1, value2, ...);
```

#### UPDATE :

---

Update existing data within a table.

```sql
UPDATE table_name SET column1 = value1, column2 = value2 WHERE condition;
```

#### DELETE :

---

Delete records from a database table.

```sql
DELETE FROM table_name WHERE condition;
```

<br>
<br>

# DQL Commands :

DQL statements are used for performing queries on the data within schema objects. The purpose of the DQL Command is to get some schema relation based on the query passed to it.

#### SELECT :

---

It is used to retrieve data from the database.

```sql
SELECT column1, column2, ...FROM table_name WHERE condition;
```

<br>
<br>

# DCL Commands :

DCL includes commands mainly deal with the rights, permissions, and other controls of the database system.

#### GRANT :

---

Assigns new privileges to a user account, allowing access to specific database objects, actions, or functions.

```sql
GRANT privilege_type ON object TO user [WITH GRANT OPTION];
```

#### REVOKE :

---

Removes previously granted privileges from a user account, taking away their access to certain database objects or actions.

```sql
REVOKE privilege_type ON object FROM user;
```

<br>
<br>

# TCL Commands :

Transactions group a set of tasks into a single execution unit. Each transaction begins with a specific task and ends when all the tasks in the group are successfully completed. If any of the tasks fail, the transaction fails.
Therefore, a transaction has only two results : success or failure.

#### BEGIN TRANSACTION :

---

Starts a new transaction.

```sql
BEGIN TRANSACTION [transaction_name];
```

#### COMMIT :

---

Saves all changes made during the transaction.

```sql
COMMIT;
```

#### ROLLBACK :

---

Undoes all changes made during the transaction.

```sql
ROLLBACK;
```

#### SAVEPOINT :

---

Creates a savepoint within the current transaction.

```sql
SAVEPOINT savepoint_name;
```

<br>
<br>

# Other Commands :

These commands work along with other commands, that is the above commands.

#### WHERE :

---

The WHERE Clause generally is used to filter the rows from a table on a specific condition. WHERE clause specifies search conditions for the rows returned by the Query and limits rows to a specific row set. If a table has a huge amount of records and if someone wants to get the particular records then using the ‘where’ clause is useful.

```sql
SELECT column1,column2,cloumn3….
FORM table_name
WHERE Condition;
```

#### ORDER BY :

---

ORDER BY keyword sort the result-set either in ascending or descending order. This clause sorts the result set in ascending order by default. In order to sort the result-set in descending order DESC keyword is used.

```sql
SELECT column_1, column_2, column_3………..
FROM Table_Name
ORDER BY column_1, column_2, column_3……. ASC|DESC;
```

    ASC : keyword for ascending order.
    DESC : keyword for descending order.

#### GROUP BY :

---

GROUP BY statement is used to group the rows that have the same value. It is used with aggregate functions. One thing is to remember about the group by clause that the tuples are grouped based on the similarity between the attribute values of tuples.

```sql
SELECT column1,column2
from table_name
GROUP BY column1,column2 ;
```

#### HAVING :

---

The HAVING clause filters groups of the GROUP BY clause and makes it possible to filter rows at the group level without destroying the information in the groups.

The Having clause is basically like the aggregate function with the Group By clause. The Having clause is used instead of WHERE with aggregate functions. While the Group By clause groups rows that have the same values into summary rows.

```sql
SELECT COUNT (SALARIES) AS COUNT_SALARIES, EMPLOYEES
FROM EMPLOYEES
GROUP BY SALARIES
HAVING COUNT(SALARIES) > 1;
```

#### DISTINCT :

---

The DISTINCT keyword is used in conjunction with the select keyword. It is helpful when there is a need to avoid duplicate values present in any specific columns/table. When we use distinct keywords only the unique values are fetched.

```sql
SELECT DISTINCT column1, column2
FROM table_name.
```

#### CREATE INDEX :

---

The CREATE INDEX statement is used to create indexes in tables.
Indexes are used to retrieve data from the database more quickly than otherwise. The users cannot see the indexes, they are just used to speed up searches/queries.

Creates an index on a table. Duplicate values are allowed.

```sql
CREATE INDEX index_name
ON table_name (column1, column2, ...);
```

<br>
<br>

# Aggregate Functions :

SQL Aggregate functions are functions where the values of multiple rows are grouped as input on certain criteria to form a single value result of more significant meaning.
It is used to summarize data, by combining multiple values to form a single result.
SQL Aggregate functions are mostly used with the GROUP BY clause of the SELECT statement.

Various Aggregate Functions are :

    1. Count()
    2. Sum()
    3. Avg()
    4. Min()
    5. Max()

```sql
--Count the number of employees
SELECT COUNT(*) AS TotalEmployees FROM Employee;

-- Calculate the total salary
SELECT SUM(Salary) AS TotalSalary FROM Employee;

-- Find the average salary
SELECT AVG(Salary) AS AverageSalary FROM Employee;

-- Get the highest salary
SELECT MAX(Salary) AS HighestSalary FROM Employee;

-- Determine the lowest salary
SELECT MIN(Salary) AS LowestSalary FROM Employee;
```

<br>

### SQL JOINS :

---

Joins are used in SQL to combine records from two or more tables based on related columns between them. They allow us to query data across multiple tables in a relational database.

##### 1. INNER JOIN :

---

Returns matching rows from both tables.

```sql
SELECT * FROM students
INNER JOIN marks ON students.id = marks.student_id;
```

##### 2. LEFT JOIN :

---

Returns all rows from the left table, with NULL for non-matching rows in the right table.

```sql
SELECT * FROM students
LEFT JOIN marks ON students.id = marks.student_id;
```

##### 3. RIGHT JOIN :

---

Returns all rows from the right table, with NULL for non-matching rows in the left table.

```sql
SELECT * FROM marks
RIGHT JOIN students ON marks.student_id = students.id;
```

##### 4. FULL JOIN :

---

Returns all rows from both tables, with NULL for non-matching rows in either table.

```sql
SELECT * FROM students
FULL JOIN marks ON students.id = marks.student_id;
```

<br>

### Views :

---

A View is a virtual table in SQL that is based on the result of a SELECT query. It does not store data itself but provides a way to simplify complex queries or aggregate data from multiple tables. When you query a view, SQL retrieves the data from the underlying tables based on the logic defined in the view.

```sql
CREATE VIEW student_scores AS
SELECT students.name, marks.mark
FROM students
INNER JOIN marks ON students.id = marks.student_id;
```

##### Usage of Views :

- Simplifies complex queries.
- Restricts access to sensitive data (security).
- Aggregates data for summaries (e.g., totals, averages).
- Provides logical data independence.

##### Limitations of Views :

- Performance issues with large datasets.
- No indexing on views.
- Limited support for INSERT, UPDATE, DELETE.
- Dependent on the structure of underlying tables.
- Views do not store data; recalculated every query.

<br>

### Subquery :

---

A subquery is a query nested inside another query.
It can be used in SELECT, INSERT, UPDATE, or DELETE statements.
Subqueries help break complex queries into smaller parts.

```sql
SELECT name FROM students
WHERE id IN (SELECT student_id FROM marks WHERE mark > 80);
```

<br>

### Stored Procedure :

---

A stored procedure is a precompiled collection of SQL statements that can be executed as a unit.
They are used to encapsulate logic, reduce code repetition, and improve performance. Can accept parameters and return values.

```sql
CREATE PROCEDURE GetStudentMarks
@StudentID BIGINT
AS
BEGIN
SELECT name, mark
FROM students
INNER JOIN marks ON students.id = marks.student_id
WHERE students.id = @StudentID;
END;
```

<br>

### Trigger :

---

A trigger is a special type of stored procedure that automatically executes when a specific event occurs on a table (INSERT, UPDATE, DELETE).
Used to enforce business rules, audit changes, or maintain data integrity.

#### 1. INSERT Trigger :

---

```sql
   CREATE TRIGGER trgAfterInsert ON marks
   AFTER INSERT
   AS
   BEGIN
   PRINT 'New mark added.'
   END;
```

#### 2. UPDATE Trigger :

---

```sql
   CREATE TRIGGER trgAfterUpdate ON marks
   AFTER UPDATE
   AS
   BEGIN
   PRINT 'Mark updated.'
   END;
```

#### 3. DELETE Trigger :

---

```sql
   CREATE TRIGGER trgAfterDelete ON marks
   AFTER DELETE
   AS
   BEGIN
   PRINT 'Mark deleted.'
   END;
```

<br>

### Functions :

---

SQL functions are routines that perform actions, usually computations, and return a value or a set of values. Functions are essential for manipulating data, performing calculations, and simplifying queries. They help modularize and reuse logic across SQL code.

```sql
CREATE FUNCTION GetFullName (@FirstName VARCHAR(50), @LastName VARCHAR(50))
RETURNS VARCHAR(100)
AS
BEGIN
RETURN @FirstName + ' ' + @LastName;
END;
```

<br>

#### Benefits of SQL Functions :

---

- <b>Reusability</b> : Can be reused across multiple queries, saving time and reducing redundancy.

- <b>Simplified Queries </b>: Encapsulate complex logic, making queries cleaner and more readable.

- <b>Modularity </b>: Separate logic from main queries, improving maintainability.

<br>

#### Limitations of SQL Functions:

---

- <b>Performance </b>: Complex functions may impact performance on large datasets.

- <b>Side Effects </b>: Cannot modify database state (no INSERT, UPDATE, or DELETE).

- <b>Limited Error Handling </b>: Less robust error handling compared to stored procedures.
