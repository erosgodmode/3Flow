USE TrioFlowDB;
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
BEGIN
    CREATE TABLE Users (
        UserID        INT IDENTITY(1,1)  PRIMARY KEY,
        FullName      NVARCHAR(100)      NOT NULL,
        ContactNumber NVARCHAR(20)       NOT NULL,
        Email         NVARCHAR(100)      NOT NULL,
        Username      NVARCHAR(50)       NOT NULL UNIQUE,
        Password      NVARCHAR(50)       NOT NULL,
        ProfileImage  VARBINARY(MAX)     NULL,
        CreatedAt     DATETIME           DEFAULT GETDATE()
    );
    PRINT '✅ Users table created successfully!';
END
ELSE
BEGIN
    PRINT '⚠️ Users table already exists. Skipping.';
END
GO