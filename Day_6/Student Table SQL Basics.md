# Student Table With SQL Basics

#### Discussed about :

    1. Create table students.
    2. Where clause.
    3. Insert values.
    4. Group by and Having.
    5. Order by and Aliases.
    6. Aggregate Functions.
    7. Length and Top

#### Example Code :

```sql

CREATE TABLE students(
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    email VARCHAR(50) UNIQUE NOT NULL,
    class INT NOT NULL DEFAULT 1
)

-- Insert into students --

INSERT INTO students (name, email, class) VALUES
('Alice Johnson', 'alice.johnson@example.com', 3),
('Bob Smith', 'bob.smith@example.com', 2),
('Charlie Davis', 'charlie.davis@example.com', 4),
('Diana Green', 'diana.green@example.com', 1),
('Ethan Moore', 'ethan.moore@example.com', 5),
('Fiona White', 'fiona.white@example.com', 2),
('George Brown', 'george.brown@example.com', 3),
('Hannah Lee', 'hannah.lee@example.com', 4);

select * from students;

-- Usage of Where clause --

select id, name, class from students where email ='george.brown@example.com';
select id, name from students where id in(1,5);

-- Order By --

select id, name ,class from students order by name asc;
select id, name ,class from students order by name desc;

-- Aliases --

select id, name as full_name ,class as grade from students;

-- Group By and Having clause --

select class, count(id) as count_of_students from students group by class;
select class, count(id) as count_of_students from students group by class having count(id)<2;

-- Top 5 listing and avoiding first 5 and fetching next 5 --

select top 5 id, name, class from students;

select id, name, class from students
order by id
offset 5 rows
fetch next 3 rows only;

-- Length function --

select len('hello');
select  name, len(name) as length_of_name from students;

-- Aggregate functions --

select count(id) as total_students from students;
select sum(class) as total_students from students;
select min(class) from students;
select max(class) from students;
select avg(class) from students;

```
