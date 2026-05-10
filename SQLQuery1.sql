IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'TrioFlowDB')
BEGIN
    CREATE DATABASE TrioFlowDB;
    PRINT '✅ TrioFlowDB created successfully!';
END
ELSE
BEGIN
    PRINT '⚠️ TrioFlowDB already exists. Skipping creation.';
END
GO