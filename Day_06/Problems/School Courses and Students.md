# School Courses and Students

#### Question :

You are working on a database for a school’s student management system.

    The system contains a table named courses that stores information about the courses offered at the school and the students enrolled in them.

#### Task :

You have been tasked to generate a report that shows the following information for each course :

```
1.  The total number of students enrolled in each course.
2.  The total fees collected for each course.
3.  The course with the maximum number of enrollments.
```

---

#### Code :

```sql

CREATE TABLE COURSES (
  course_id INT PRIMARY KEY IDENTITY(1,1),
  course_name VARCHAR(50) NOT NULL UNIQUE,
  fees INT NOT NULL DEFAULT 500,
  num_students INT NOT NULL
);

INSERT INTO COURSES (course_name, fees, num_students)
VALUES
('cs', 5000, 45),
('it', 4900, 12),
('ec', 4800, 14),
('ai', 7900, 10),
('ee', 8000, 16),
('mech', 6900, 17),
('civil', 8900, 18),
('ts', 5000, 12),
('ml', 6000, 10),
('csharp', 5800, 12);

-- The total number of students enrolled --

SELECT course_name, num_students AS total_number_of_students
FROM COURSES;

-- Calculate the total fees collected for each course --

SELECT course_name, (fees * num_students) AS total_fees_collected
FROM COURSES;

-- Determine the course with the maximum number of enrollments --

SELECT TOP 1 course_name, num_students AS maximum_no_enrollments
FROM COURSES
ORDER BY num_students DESC;

```
