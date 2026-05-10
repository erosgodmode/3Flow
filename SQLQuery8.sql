USE TrioFlowDB;
GO
 
IF NOT EXISTS (SELECT * FROM Stock WHERE Description = 'Gallon Refill')
BEGIN
    INSERT INTO Stock (Description, Price, Quantity)
    VALUES
        ('Gallon Refill',  25.00, 500),
        ('Home Delivery',  50.00, 200),
        ('New Container', 150.00, 100);
    PRINT '✅ Stock data inserted.';
END
ELSE
    PRINT '⚠️ Stock data already exists. Skipping.';
GO