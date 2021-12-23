
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/23/2021 07:51:12
-- Generated from EDMX file: D:\ترم4\بانک اطلاعاتی\git progect\WindowsFormsApplication1\WindowsFormsApplication1\contex2021.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Db_anbar];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [tahvildahandeh] nvarchar(max)  NOT NULL
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
    [group] nvarchar(max)  NOT NULL
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