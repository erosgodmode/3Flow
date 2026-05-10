USE TrioFlowDB;
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Order_Master' AND xtype='U')
BEGIN
    CREATE TABLE Order_Master (
        OrderID     INT IDENTITY(221100,1) PRIMARY KEY,
        OrderDate   DATE                   NOT NULL DEFAULT GETDATE(),
        CustomerID  INT                    NOT NULL,
        FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
    );
    PRINT '✅ Order_Master table created successfully!';
END
ELSE
BEGIN
    PRINT '⚠️ Order_Master table already exists. Skipping.';
END
GO