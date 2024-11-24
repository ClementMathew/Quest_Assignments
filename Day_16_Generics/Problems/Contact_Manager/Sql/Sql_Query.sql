
-- Contacts --

CREATE TABLE Contacts (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Name NVARCHAR(100) NOT NULL,       
    Email NVARCHAR(100) NOT NULL,    
    Phone NVARCHAR(15) NOT NULL       
);

select * from Contacts;