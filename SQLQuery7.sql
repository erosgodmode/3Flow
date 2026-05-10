USE TrioFlowDB;
GO
 
IF NOT EXISTS (SELECT * FROM Users WHERE Username = 'admin')
BEGIN
    INSERT INTO Users (FullName, ContactNumber, Email, Username, Password)
    VALUES ('Admin User', '09000000000', 'admin@trioflow.com', 'admin', 'admin123');
    PRINT '✅ Admin user inserted.';
END
ELSE
    PRINT '⚠️ Admin user already exists. Skipping.';
 
IF NOT EXISTS (SELECT * FROM Users WHERE Username = 'staff')
BEGIN
    INSERT INTO Users (FullName, ContactNumber, Email, Username, Password)
    VALUES ('Staff User', '09111111111', 'staff@trioflow.com', 'staff', 'staff123');
    PRINT '✅ Staff user inserted.';
END
ELSE
    PRINT '⚠️ Staff user already exists. Skipping.';
GO