
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2021 17:46:48
-- Generated from EDMX file: C:\Users\79196\source\repos\PYATAYALABA\PYATAYALABA\EntityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [D:\BDLR6\BANKDB.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserDataBalance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BalanceSet] DROP CONSTRAINT [FK_UserDataBalance];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserDataSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserDataSet];
GO
IF OBJECT_ID(N'[dbo].[BalanceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BalanceSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserDataSet'
CREATE TABLE [dbo].[UserDataSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BalanceSet'
CREATE TABLE [dbo].[BalanceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Summa] nvarchar(max)  NOT NULL,
    [UserData_Id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserDataSet'
ALTER TABLE [dbo].[UserDataSet]
ADD CONSTRAINT [PK_UserDataSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BalanceSet'
ALTER TABLE [dbo].[BalanceSet]
ADD CONSTRAINT [PK_BalanceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserData_Id] in table 'BalanceSet'
ALTER TABLE [dbo].[BalanceSet]
ADD CONSTRAINT [FK_UserDataBalance]
    FOREIGN KEY ([UserData_Id])
    REFERENCES [dbo].[UserDataSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDataBalance'
CREATE INDEX [IX_FK_UserDataBalance]
ON [dbo].[BalanceSet]
    ([UserData_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------