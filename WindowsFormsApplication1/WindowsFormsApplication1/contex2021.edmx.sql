
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/14/2022 02:59:01
-- Generated from EDMX file: D:\ترم4\بانک اطلاعاتی\git progect\WindowsFormsApplication1\WindowsFormsApplication1\contex2021.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Db_anbar3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[vorods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[vorods];
GO
IF OBJECT_ID(N'[dbo].[khorojes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[khorojes];
GO
IF OBJECT_ID(N'[dbo].[khalaye_mayoub]', 'U') IS NOT NULL
    DROP TABLE [dbo].[khalaye_mayoub];
GO
IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO
IF OBJECT_ID(N'[dbo].[personels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[personels];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'vorods'
CREATE TABLE [dbo].[vorods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date] nvarchar(max)  NOT NULL,
    [group] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [model] nvarchar(max)  NOT NULL,
    [count] nvarchar(max)  NOT NULL,
    [tahvilgirandeh] nvarchar(max)  NOT NULL,
    [tahvildahandeh] nvarchar(max)  NOT NULL,
    [tell] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'khorojes'
CREATE TABLE [dbo].[khorojes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [model] nvarchar(max)  NOT NULL,
    [count] nvarchar(max)  NOT NULL,
    [tahvildahandeh] nvarchar(max)  NOT NULL,
    [tahvilgirandeh] nvarchar(max)  NOT NULL,
    [group] nvarchar(max)  NOT NULL,
    [tell] nvarchar(max)  NOT NULL,
    [adress] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'khalaye_mayoub'
CREATE TABLE [dbo].[khalaye_mayoub] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [group] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [model] nvarchar(max)  NOT NULL,
    [count] nvarchar(max)  NOT NULL,
    [discription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [family] nvarchar(max)  NOT NULL,
    [level] nvarchar(max)  NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'personels'
CREATE TABLE [dbo].[personels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [family] nvarchar(max)  NOT NULL,
    [codemeli] nvarchar(max)  NOT NULL,
    [job] nvarchar(max)  NOT NULL,
    [phonenumber] nvarchar(max)  NOT NULL,
    [adress] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'vorods'
ALTER TABLE [dbo].[vorods]
ADD CONSTRAINT [PK_vorods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'khorojes'
ALTER TABLE [dbo].[khorojes]
ADD CONSTRAINT [PK_khorojes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'khalaye_mayoub'
ALTER TABLE [dbo].[khalaye_mayoub]
ADD CONSTRAINT [PK_khalaye_mayoub]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'personels'
ALTER TABLE [dbo].[personels]
ADD CONSTRAINT [PK_personels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------