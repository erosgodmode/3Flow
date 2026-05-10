USE TrioFlowDB;
GO

SELECT 'Users'         AS [Table], COUNT(*) AS [Records] FROM Users
UNION ALL
SELECT 'Customer',      COUNT(*) FROM Customer
UNION ALL
SELECT 'Stock',         COUNT(*) FROM Stock
UNION ALL
SELECT 'Order_Master',  COUNT(*) FROM Order_Master
UNION ALL
SELECT 'Order_Details', COUNT(*) FROM Order_Details;
GO