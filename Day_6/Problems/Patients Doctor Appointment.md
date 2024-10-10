```sql
﻿
CREATE TABLE PATIENTS(
    id INT PRIMARY KEY IDENTITY(100,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    gender VARCHAR(10) CHECK(gender IN ('M','F','Other')),
    age INT CHECK (age >= 0 AND age < 120),
    phone_number VARCHAR(15),
    email VARCHAR(100) UNIQUE NOT NULL,
    created_at DATETIME2 DEFAULT GETDATE()
);

CREATE TABLE APPOINTMENTS (
    id INT PRIMARY KEY IDENTITY(1,1),
    patient_id INT,
    appointment_date DATE CHECK (appointment_date >= GETDATE()),
    appointment_time TIME,
    reason_for_visit VARCHAR(250) NOT NULL,
    doctor_name VARCHAR(50) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (patient_id) REFERENCES patients(id)
);

-- INSERTING --

INSERT INTO PATIENTS (first_name, last_name, gender, age, phone_number, email)
VALUES
('Manu', 'Sachin', 'M', 28, '9876543210', 'manu.sachin@example.com'),
('Sachu', 'Raj', 'M', 35, '9876543211', 'sachu.raj@example.com'),
('Midhun', 'Pillai', 'M', 40, '9876543212', 'midhun.pillai@example.com'),
('Vibhav', 'Kumar', 'M', 25, '9876543213', 'vibhav.kumar@example.com'),
('Riya', 'Menon', 'F', 30, '9876543214', 'riya.menon@example.com'),
('Anjali', 'Nair', 'F', 32, '9876543215', 'anjali.nair@example.com'),
('Akhil', 'Varma', 'M', 29, '9876543216', 'akhil.varma@example.com'),
('Meera', 'Reddy', 'F', 26, '9876543217', 'meera.reddy@example.com');

INSERT INTO APPOINTMENTS (patient_id, appointment_date, appointment_time, reason_for_visit, doctor_name)
VALUES
(100, '2024-10-15', '10:00:00', 'Routine checkup', 'Dr. Nair'),
(101, '2024-10-16', '11:30:00', 'Follow-up for diabetes', 'Dr. Thomas'),
(102, '2024-10-17', '09:00:00', 'Consultation for blood pressure', 'Dr. Menon'),
(103, '2024-10-18', '14:00:00', 'Eye examination', 'Dr. Radhakrishnan'),
(104, '2024-10-19', '13:00:00', 'Physical therapy', 'Dr. Iyer'),
(105, '2024-10-20', '15:00:00', 'Back pain treatment', 'Dr. Gupta'),
(106, '2024-10-21', '10:30:00', 'General consultation', 'Dr. Sharma'),
(107, '2024-10-22', '12:00:00', 'Cardiology checkup', 'Dr. Pillai');

SELECT * FROM PATIENTS;
SELECT * FROM APPOINTMENTS;

```
