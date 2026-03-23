USE TrioFlowDB;
GO

IF OBJECT_ID('Users', 'U') IS NOT NULL
    DROP TABLE Users;
GO

CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    email NVARCHAR(100) NOT NULL
);
GO

INSERT INTO Users (name, email) 
VALUES ('Neil', 'neil@gmail.com');
GO
