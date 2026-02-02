USE Master;
--DROP DATABASE Users;
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'Users') 
BEGIN
    Print(N'БД уже существует');
END 
ELSE
BEGIN
    CREATE DATABASE Users;
    Print(N'БД Users создана');
END
GO
USE Users;
IF EXISTS (SELECT TABLE_NAME FROM 
INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Persons')
BEGIN
    Print(N'Таблица Persons уже существует');
END
ELSE
BEGIN
    CREATE TABLE Persons 
    (id INTEGER Primary KEY IDENTITY(10,2),
                Name VARCHAR, Age INTEGER);
    Print(N'Таблица Persons создана');
END 