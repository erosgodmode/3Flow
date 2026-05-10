USE TrioFlowDB;
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Customer' AND xtype='U')
BEGIN
    CREATE TABLE Customer (
        CustomerID  INT IDENTITY(1001,1) PRIMARY KEY,
        LastName    NVARCHAR(50)         NOT NULL,
        FirstName   NVARCHAR(50)         NOT NULL,
        MI          NVARCHAR(5)          NULL,
        Address     NVARCHAR(200)        NOT NULL,
        Email       NVARCHAR(100)        NULL,
        ContactNo   NVARCHAR(20)         NULL
    );
    PRINT '✅ Customer table created successfully!';
END
ELSE
BEGIN
    PRINT '⚠️ Customer table already exists. Skipping.';
END
GO