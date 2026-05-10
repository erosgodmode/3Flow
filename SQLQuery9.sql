USE TrioFlowDB;
GO
 
IF NOT EXISTS (SELECT * FROM Customer WHERE CustomerID = 1001)
BEGIN
    SET IDENTITY_INSERT Customer ON;
 
    INSERT INTO Customer (CustomerID, LastName, FirstName, MI, Address, Email, ContactNo)
    VALUES
        (1001, 'BUCOL',  'JOSE',   'Y', 'CEBU CITY',    'jybuc@email.com',   '09171000001'),
        (1002, 'RIZAL',  'JOSE',   'M', 'CEBU CITY',    'jrizal@email.com',  '09171000002'),
        (1003, 'ANDRES', 'JOSE',   'N', 'CALAMBA',      'psei@email.com',    '09171000003'),
        (1004, 'PINO',   'PHILIP', 'V', 'MANILA',       'andrei@email.com',  '09171000004'),
        (1005, 'LEE',    'BRUCE',  'K', 'CEBU CITY',    'blee@email.com',    '09171000005'),
        (1006, 'MC',     'DONALD', 'T', 'CEBU CITY',    'mc@email.com',      '09171000006'),
        (1007, 'SMITH',  'JACK',   'T', 'MANDAUE CITY', 'smith@email.com',   '09171000007'),
        (1008, 'BEE',    'JOLLY',  'R', 'CEBU CITY',    'bee@email.com',     '09171000008');
 
    SET IDENTITY_INSERT Customer OFF;
    PRINT '✅ Customer data inserted.';
END
ELSE
    PRINT '⚠️ Customer data already exists. Skipping.';
GO