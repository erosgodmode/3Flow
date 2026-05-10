USE TrioFlowDB;
GO

PRINT '========================================';
PRINT ' TrioFlowDB - VERIFICATION REPORT';
PRINT '========================================';

-- Check record counts
SELECT 'Users'         AS [Table], COUNT(*) AS [Records] FROM Users
UNION ALL
SELECT 'Customer',                  COUNT(*) FROM Customer
UNION ALL
SELECT 'Stock',                     COUNT(*) FROM Stock
UNION ALL
SELECT 'Order_Master',              COUNT(*) FROM Order_Master
UNION ALL
SELECT 'Order_Details',             COUNT(*) FROM Order_Details;

-- Show all stock items
PRINT '';
PRINT '--- STOCK ITEMS ---';
SELECT StockID, Description, Price, Quantity FROM Stock ORDER BY StockID;

-- Show all customers
PRINT '';
PRINT '--- CUSTOMERS ---';
SELECT CustomerID, FirstName, LastName, MI, Address FROM Customer ORDER BY CustomerID;

-- Show all users (no password shown)
PRINT '';
PRINT '--- USERS ---';
SELECT UserID, FullName, Username, Email FROM Users ORDER BY UserID;

PRINT '';
PRINT '✅ Verification complete!';
GO