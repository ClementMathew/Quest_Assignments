create database NewDb;
/_ STUDENT - Basic student details
SUBJECT - Name, Code
MARKS - ExamId, Subject, Mark, StudentId
EXAM - MIn Mark, Max Mark _/

use NewDb;

CREATE TABLE STUDENT(
id bigint primary key identity,
name varchar(50) not null
);

CREATE TABLE SUBJECT(
id bigint primary key identity(100,1),
name varchar(50) not null unique,
code VARCHAR(10) NOT NULL UNIQUE
);

create table exam(
id bigint primary key identity(200,1),
name varchar(50) not null,
min_mark int not null default 0,
max_mark int not null default 100
);

create table marks(
id bigint primary key identity,
mark int not null,
student_id bigint,
subject_id bigint,
exam_id bigint,

    constraint fk_student_id foreign key(student_id) references student(id),
    constraint fk_subject_id foreign key(subject_id) references subject(id),
    constraint fk_exam_id foreign key (exam_id) references exam(id)
    );

    ----- Insert values into the STUDENT table

INSERT INTO STUDENT (name) VALUES ('gatha');
INSERT INTO STUDENT (name) VALUES ('geethu');

-- Insert values into the SUBJECT table
INSERT INTO SUBJECT (name, code) VALUES ('Mathematics', 'MATH101');
INSERT INTO SUBJECT (name, code) VALUES ('Physics', 'PHY101');

-- Insert values into the EXAM table
INSERT INTO EXAM (name, min_mark, max_mark) VALUES ('Midevaluation', 35, 100);
INSERT INTO EXAM (name, min_mark, max_mark) VALUES ('Final', 40, 100);

-- Insert values into the MARKS table
INSERT INTO MARKS (mark, student_id, subject_id, exam_id)
VALUES (85, 1, 100, 200),(90,1,100,201),(98,1,101,201),(89,2,100,200),(78,2,100,201),(60,2,101,200),(90,2,101,200);

select _ from student;
select _ from subject;
select _ from exam;
select _ from marks;

--- joins-----
/_ retrieve the marks and student and exam details fully-- _/
select marks.id as mark_id,
marks.mark,
student.id as student_id,
student.name as student_name,
subject.id as subject_id,
subject.name as subject_name,
exam.id as exam_id,
exam.name as exam_name
from marks inner join student on marks.student_id = student.id inner join subject on marks.subject_id = subject.id inner join exam on marks.exam_id = exam.id;

-------if a subject name is given fetch all the marks of that subject by students----
select subject.id as subject_id,
subject.name,
student.id as student_id,
student.name as student_name,
marks.id as mark_id,
marks.mark from subject
inner join marks on subject.id = marks.subject_id inner join student on marks.student_id = student.id where subject.name = 'Mathematics';
-------if student id is given fetch all the exams of that students--
SELECT DISTINCT
student.id AS student_id,
student.name,
exam.id AS exam_id,
exam.name AS exam_name
FROM student
INNER JOIN marks ON student.id = marks.student_id
INNER JOIN exam ON marks.exam_id = exam.id
WHERE student.id = 1;
