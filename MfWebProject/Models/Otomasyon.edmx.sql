
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2023 15:36:52
-- Generated from EDMX file: E:\MVS Çalışmalarım\MfWebProject\MfWebProject\Models\Otomasyon.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_MYO];
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

-- Creating table 'OgrencilerSet'
CREATE TABLE [dbo].[OgrencilerSet] (
    [OgrenciNo] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Yas] int  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KampuslerSet'
CREATE TABLE [dbo].[KampuslerSet] (
    [KampusNo] int IDENTITY(1,1) NOT NULL,
    [KampusAd] nvarchar(max)  NOT NULL,
    [KampusSayisi] int  NOT NULL
);
GO

-- Creating table 'AkademisyenlerSet'
CREATE TABLE [dbo].[AkademisyenlerSet] (
    [AkademiNo] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Calısmalar] nvarchar(max)  NOT NULL,
    [Bolum] nvarchar(max)  NOT NULL,
    [Dal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FakultelerSet'
CREATE TABLE [dbo].[FakultelerSet] (
    [FakulteNo] int IDENTITY(1,1) NOT NULL,
    [FakulteAd] nvarchar(max)  NOT NULL,
    [FakulteDurum] nvarchar(max)  NOT NULL,
    [AKTS] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [OgrenciNo] in table 'OgrencilerSet'
ALTER TABLE [dbo].[OgrencilerSet]
ADD CONSTRAINT [PK_OgrencilerSet]
    PRIMARY KEY CLUSTERED ([OgrenciNo] ASC);
GO

-- Creating primary key on [KampusNo] in table 'KampuslerSet'
ALTER TABLE [dbo].[KampuslerSet]
ADD CONSTRAINT [PK_KampuslerSet]
    PRIMARY KEY CLUSTERED ([KampusNo] ASC);
GO

-- Creating primary key on [AkademiNo] in table 'AkademisyenlerSet'
ALTER TABLE [dbo].[AkademisyenlerSet]
ADD CONSTRAINT [PK_AkademisyenlerSet]
    PRIMARY KEY CLUSTERED ([AkademiNo] ASC);
GO

-- Creating primary key on [FakulteNo] in table 'FakultelerSet'
ALTER TABLE [dbo].[FakultelerSet]
ADD CONSTRAINT [PK_FakultelerSet]
    PRIMARY KEY CLUSTERED ([FakulteNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------