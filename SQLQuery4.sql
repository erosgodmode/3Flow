USE TrioFlowDB;
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Stock' AND xtype='U')
BEGIN
    CREATE TABLE Stock (
        StockID     INT IDENTITY(101,1) PRIMARY KEY,
        Description NVARCHAR(100)       NOT NULL,
        Price       DECIMAL(10,2)       NOT NULL,
        Quantity    INT                 DEFAULT 0
    );
    PRINT '✅ Stock table created successfully!';
END
ELSE
BEGIN
    PRINT '⚠️ Stock table already exists. Skipping.';
END
GO