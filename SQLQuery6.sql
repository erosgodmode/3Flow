USE TrioFlowDB;
GO
 
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Order_Details' AND xtype='U')
BEGIN
    CREATE TABLE Order_Details (
        DetailID  INT IDENTITY(1,1) PRIMARY KEY,
        OrderID   INT               NOT NULL,
        StockID   INT               NOT NULL,
        Qty       INT               NOT NULL,
        FOREIGN KEY (OrderID)  REFERENCES Order_Master(OrderID),
        FOREIGN KEY (StockID)  REFERENCES Stock(StockID)
    );
    PRINT '✅ Order_Details table created successfully!';
END
ELSE
BEGIN
    PRINT '⚠️ Order_Details table already exists. Skipping.';
END
GO