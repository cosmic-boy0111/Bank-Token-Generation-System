
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/30/2023 13:21:20
-- Generated from EDMX file: C:\Users\Admin\source\repos\Bank-Token-Generation-System\Server\Models\BankModels.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Bank-Token-Generation-System];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[services];
GO
IF OBJECT_ID(N'[dbo].[Tokens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tokens];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [AccountNumber] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'services'
CREATE TABLE [dbo].[services] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Time] int  NOT NULL
);
GO

-- Creating table 'Tokens'
CREATE TABLE [dbo].[Tokens] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TokenNo] int  NOT NULL,
    [ServiceName] nvarchar(max)  NOT NULL,
    [Status] int  NOT NULL,
    [WaitingTime] int  NOT NULL,
    [NoShowCount] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'services'
ALTER TABLE [dbo].[services]
ADD CONSTRAINT [PK_services]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tokens'
ALTER TABLE [dbo].[Tokens]
ADD CONSTRAINT [PK_Tokens]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------