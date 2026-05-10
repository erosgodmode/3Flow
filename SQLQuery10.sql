USE TrioFlowDB;
GO

-- View: Full Order Summary (useful for reports)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='vw_OrderSummary' AND xtype='V')
BEGIN
    EXEC('
    CREATE VIEW vw_OrderSummary AS
    SELECT
        om.OrderID,
        om.OrderDate,
        c.CustomerID,
        c.FirstName,
        c.LastName,
        c.MI,
        c.Address,
        s.StockID,
        s.Description,
        s.Price,
        od.Qty,
        (s.Price * od.Qty) AS Total
    FROM Order_Master om
    INNER JOIN Customer      c  ON om.CustomerID = c.CustomerID
    INNER JOIN Order_Details od ON om.OrderID    = od.OrderID
    INNER JOIN Stock         s  ON od.StockID    = s.StockID
    ');
    PRINT '✅ vw_OrderSummary view created.';
END
ELSE
    PRINT '⚠️ vw_OrderSummary already exists. Skipping.';
GO

-- View: Customer Bill (total per order)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='vw_CustomerBill' AND xtype='V')
BEGIN
    EXEC('
    CREATE VIEW vw_CustomerBill AS
    SELECT
        om.OrderID,
        om.OrderDate,
        c.CustomerID,
        c.FirstName,
        c.LastName,
        SUM(s.Price * od.Qty) AS TotalBill
    FROM Order_Master om
    INNER JOIN Customer      c  ON om.CustomerID = c.CustomerID
    INNER JOIN Order_Details od ON om.OrderID    = od.OrderID
    INNER JOIN Stock         s  ON od.StockID    = s.StockID
    GROUP BY om.OrderID, om.OrderDate, c.CustomerID, c.FirstName, c.LastName
    ');
    PRINT '✅ vw_CustomerBill view created.';
END
ELSE
    PRINT '⚠️ vw_CustomerBill already exists. Skipping.';
GO