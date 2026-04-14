USE TrioFlowDB;

DROP TABLE Users;

CREATE TABLE Users (
    UserID        INT IDENTITY(1,1) PRIMARY KEY,
    Username      NVARCHAR(50)  NOT NULL UNIQUE,
    Password      NVARCHAR(100) NOT NULL,
    CreatedAt     DATETIME DEFAULT GETDATE(),
    FullName      NVARCHAR(100),
    ContactNumber NVARCHAR(20),
    Email         NVARCHAR(100),
    ProfileImage  VARBINARY(MAX)
);