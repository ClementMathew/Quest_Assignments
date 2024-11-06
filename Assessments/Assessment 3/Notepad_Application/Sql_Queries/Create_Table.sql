CREATE TABLE Notes(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Title VARCHAR(20) NOT NULL,
	Content VARCHAR(MAX) NOT NULL,
	CreatedAt DATETIME DEFAULT GETDATE(),
	UpdatedAt DATETIME DEFAULT GETDATE()
);

