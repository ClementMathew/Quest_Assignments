NOTES ON MSSQL

// DDL COMMANDS:
DDL or Data Definition Language actually consists of the SQL commands that can be used to define the database schema. It simply deals with descriptions of the database schema and is used to create and modify the structure of database objects in the database.
DDL is a set of SQL commands used to create, modify, and delete database structures but not data.
The commands are :
• CREATE: Create database or its objects (table, index, function, views, store procedure, and triggers)

CREATE TABLE table_name (column1 data_type, column2 data_type, ...);

• ALTER : Alter the structure of the database

ALTER TABLE table_name ADD COLUMN column_name data_type;

• TRUNCATE: Remove all records from a table, including all spaces allocated for the records are removed.

TRUNCATE TABLE table_name;

• DROP: Delete objects from the database.

DROP TABLE table_name;

//DML COMMANDS:
The SQL commands that deal with the manipulation of data present in the database belong to DML or Data Manipulation Language and this includes most of the SQL statements.
It is the component of the SQL statement that controls access to data and to the database.
• INSERT: Insert data into a table.
INSERT INTO table_name (column1, column2, ...) VALUES (value1, value2, ...);

• UPDATE: Update existing data within a table.
UPDATE table_name SET column1 = value1, column2 = value2 WHERE condition;

• DELETE: Delete records from a database table.
DELETE FROM table_name WHERE condition;
//DQL COMMANDS:
DQL statements are used for performing queries on the data within schema objects. The purpose of the DQL Command is to get some schema relation based on the query passed to it. It includes the SELECT statement.
• SELECT: It is used to retrieve data from the database.

SELECT column1, column2, ...FROM table_name WHERE condition;

//DCL (Data Control Language)
DCL includes commands such as GRANT and REVOKE which mainly deal with the rights, permissions, and other controls of the database system.

• GRANT: Assigns new privileges to a user account, allowing access to specific database objects, actions, or functions.

• REVOKE: Removes previously granted privileges from a user account, taking away their access to certain database objects or actions.

//TCL (Transaction Control Language)

Transactions group a set of tasks into a single execution unit. Each transaction begins with a specific task and ends when all the tasks in the group are successfully completed. If any of the tasks fail, the transaction fails.
Therefore, a transaction has only two results: success or failure.
BEGIN
TRANSACTION Starts a new transaction BEGIN TRANSACTION [transaction_name];
COMMIT Saves all changes made during the transaction COMMIT;
ROLLBACK Undoes all changes made during the transaction ROLLBACK;
SAVEPOINT Creates a savepoint within the current transaction SAVEPOINT savepoint_name;

//Constraints:

Constraints are the rules that we can apply on the type of data in a table. That is, we can specify the limit on the type of data that can be stored in a particular column in a table using constraints.

//The WHERE Clause

The WHERE Clause generally is used to filter the rows from a table on a specific condition. WHERE clause specifies search conditions for the rows returned by the Query and limits rows to a specific row set. If a table has a huge amount of records and if someone wants to get the particular records then using the ‘where’ clause is useful. The Syntax of the WHERE Clause is

SELECT column1,column2,cloumn3….
FORM table_name
WHERE Condition;

//Order By:

Order by keyword sort the result-set either in ascending or descending order. This clause sorts the result set in ascending order by default. In order to sort the result-set in descending order DESC keyword is used.

SELECT column_1, column_2, column_3………..
FROM Table_Name
ORDER BY column_1, column_2, column_3……. ASC|DESC;

ASC: keyword for ascending order.
DESC: keyword for descending order.

//Group By

Group by statement is used to group the rows that have the same value. It is used with aggregate functions for example AVG(), COUNT(), SUM()etc. One thing is to remember about the group by clause that the tuples are grouped based on the similarity between the attribute values of tuples.

Syntax

SELECT column1,column2
from table_name
GROUP BY column1,column2 ;

//HAVING :
The HAVING clause filters groups of the GROUP BY clause and makes it possible to filter rows at the group level without destroying the information in the groups.
The Having Clause is basically like the aggregate function with the GROUP BY clause. The HAVING clause is used instead of WHERE with aggregate functions. While the GROUP BY Clause groups rows that have the same values into summary rows.

SELECT COUNT (SALARIES) AS COUNT_SALARIES, EMPLOYEES
FROM EMPLOYEES
GROUP BY SALARIES
HAVING COUNT(SALARIES) > 1;

//DISTINCT:

The distinct keyword is used in conjunction with the select keyword. It is helpful when there is a need to avoid duplicate values present in any specific columns/table. When we use distinct keywords only the unique values are fetched.

Syntax:
SELECT DISTINCT column1, column2
FROM table_name.
SQL CREATE INDEX Statement:
The CREATE INDEX statement is used to create indexes in tables.
Indexes are used to retrieve data from the database more quickly than otherwise. The users cannot see the indexes, they are just used to speed up searches/queries.
Creates an index on a table. Duplicate values are allowed:
CREATE INDEX index_name
ON table_name (column1, column2, ...);

//AGGREGATE FUNCTIONS
SQL Aggregate functions :are functions where the values of multiple rows are grouped as input on certain criteria to form a single value result of more significant meaning.
It is used to summarize data, by combining multiple values to form a single result.
SQL Aggregate functions are mostly used with the GROUP BY clause of the SELECT statement.
Various Aggregate Functions

1. Count()
2. Sum()
3. Avg()
4. Min()
5. Max()
   --Count the number of employees
   SELECT COUNT(\*) AS TotalEmployees FROM Employee;

-- Calculate the total salary
SELECT SUM(Salary) AS TotalSalary FROM Employee;

-- Find the average salary
SELECT AVG(Salary) AS AverageSalary FROM Employee;

-- Get the highest salary
SELECT MAX(Salary) AS HighestSalary FROM Employee;

-- Determine the lowest salary
SELECT MIN(Salary) AS LowestSalary FROM Employee;

//SQL JOINS
Joins are used in SQL to combine records from two or more tables based on related columns between them. They allow us to query data across multiple tables in a relational database.
• INNER JOIN: Returns matching rows from both tables.
SELECT \* FROM students
INNER JOIN marks ON students.id = marks.student_id;

• LEFT JOIN: Returns all rows from the left table, with NULL for non-matching rows in the right table.
SELECT \* FROM students
LEFT JOIN marks ON students.id = marks.student_id;

• RIGHT JOIN: Returns all rows from the right table, with NULL for non-matching rows in the left table.

SELECT \* FROM marks
RIGHT JOIN students ON marks.student_id = students.id;

• FULL JOIN: Returns all rows from both tables, with NULL for non-matching rows in either table.

           SELECT * FROM students
           FULL JOIN marks ON students.id = marks.student_id;


//Views:

A View is a virtual table in SQL that is based on the result of a SELECT query. It does not store data itself but provides a way to simplify complex queries or aggregate data from multiple tables. When you query a view, SQL retrieves the data from the underlying tables based on the logic defined in the view.

CREATE VIEW student_scores AS
SELECT students.name, marks.mark
FROM students
INNER JOIN marks ON students.id = marks.student_id;

Usage of Views:

1. Simplifies complex queries.
2. Restricts access to sensitive data (security).
3. Aggregates data for summaries (e.g., totals, averages).
4. Provides logical data independence.
   Limitations of Views:
5. Performance issues with large datasets.
6. No indexing on views.
7. Limited support for INSERT, UPDATE, DELETE.
8. Dependent on the structure of underlying tables.
9. Views do not store data; recalculated every query.

//Subquery:
• A subquery is a query nested inside another query.
• It can be used in SELECT, INSERT, UPDATE, or DELETE statements.
• Subqueries help break complex queries into smaller parts.
Example:
SELECT name FROM students
WHERE id IN (SELECT student_id FROM marks WHERE mark > 80);

//Stored Procedure:
• A stored procedure is a precompiled collection of SQL statements that can be executed as a unit.
• They are used to encapsulate logic, reduce code repetition, and improve performance.
• Can accept parameters and return values.
Example:
CREATE PROCEDURE GetStudentMarks
@StudentID BIGINT
AS
BEGIN
SELECT name, mark
FROM students
INNER JOIN marks ON students.id = marks.student_id
WHERE students.id = @StudentID;
END;

//Trigger:
• A trigger is a special type of stored procedure that automatically executes when a specific event occurs on a table (INSERT, UPDATE, DELETE).
• Used to enforce business rules, audit changes, or maintain data integrity.
Examples:

1. INSERT Trigger:
   CREATE TRIGGER trgAfterInsert ON marks
   AFTER INSERT
   AS
   BEGIN
   PRINT 'New mark added.'
   END;
2. UPDATE Trigger:
   CREATE TRIGGER trgAfterUpdate ON marks
   AFTER UPDATE
   AS
   BEGIN
   PRINT 'Mark updated.'
   END;
3. DELETE Trigger:
   CREATE TRIGGER trgAfterDelete ON marks
   AFTER DELETE
   AS
   BEGIN
   PRINT 'Mark deleted.'
   END;

//FUNCTIONS

SQL functions are routines that perform actions, usually computations, and return a value or a set of values. Functions are essential for manipulating data, performing calculations, and simplifying queries. They help modularize and reuse logic across SQL code.

CREATE FUNCTION GetFullName (@FirstName VARCHAR(50), @LastName VARCHAR(50))
RETURNS VARCHAR(100)
AS
BEGIN
RETURN @FirstName + ' ' + @LastName;
END;

Benefits of SQL Functions:
• Reusability: Can be reused across multiple queries, saving time and reducing redundancy.
• Simplified Queries: Encapsulate complex logic, making queries cleaner and more readable.
• Modularity: Separate logic from main queries, improving maintainability.
Limitations of SQL Functions:
• Performance: Complex functions may impact performance on large datasets.
• Side Effects: Cannot modify database state (no INSERT, UPDATE, or DELETE).
• Limited Error Handling: Less robust error handling compared to stored procedures.
