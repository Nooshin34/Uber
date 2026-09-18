/*
    Run this script in SSMS while connected to database [UberAdo].

    1. If UberAdo does not exist yet, connect to [master] and run CreateDatabase.sql.
    2. In the SSMS database dropdown, select [UberAdo].
    3. Execute this script.

    Do not keep CREATE DATABASE in this file; SSMS often drops the
    connection when a database is created in the same script as table DDL.
*/

IF DB_NAME() <> N'UberAdo'
BEGIN
    RAISERROR('Select database UberAdo in SSMS, then run this script again.', 16, 1);
    SET NOEXEC ON;
END
GO

IF OBJECT_ID(N'[dbo].[Role]', N'U') IS NOT NULL
BEGIN
    IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_User_Role')
        ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Role];

    DROP TABLE [dbo].[Role];
END
GO

IF COL_LENGTH(N'[dbo].[User]', N'RoleId') IS NOT NULL
BEGIN
    IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_User_Role')
        ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Role];

    ALTER TABLE [dbo].[User] DROP COLUMN [RoleId];
END
GO

IF OBJECT_ID(N'[dbo].[User]', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[User]
    (
        [Id] BIGINT IDENTITY(1,1) NOT NULL CONSTRAINT PK_User PRIMARY KEY,
        [UserName] NVARCHAR(100) NOT NULL,
        [PasswordHash] NVARCHAR(200) NOT NULL,
        [FirstName] NVARCHAR(100) NOT NULL,
        [LastName] NVARCHAR(100) NOT NULL,
        [PhoneNumber] NVARCHAR(11) NOT NULL,
        [IsActive] BIT NOT NULL CONSTRAINT DF_User_IsActive DEFAULT (1),
        [CreatedAt] DATETIME2 NOT NULL CONSTRAINT DF_User_CreatedAt DEFAULT (SYSUTCDATETIME()),
        [LastLoginAt] DATETIME2 NULL,
        [IsDeleted] BIT NOT NULL CONSTRAINT DF_User_IsDeleted DEFAULT (0),
        [DeletedAt] DATETIME2 NOT NULL CONSTRAINT DF_User_DeletedAt DEFAULT ('0001-01-01')
    );
END
GO

IF OBJECT_ID(N'[dbo].[User]', N'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE object_id = OBJECT_ID(N'[dbo].[User]')
          AND is_primary_key = 1
   )
BEGIN
    ALTER TABLE [dbo].[User]
    ADD CONSTRAINT PK_User PRIMARY KEY ([Id]);
END
GO

IF OBJECT_ID(N'[dbo].[Car]', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Car]
    (
        [Id] BIGINT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Car PRIMARY KEY,
        [UserId] BIGINT NOT NULL,
        [Brand] NVARCHAR(100) NOT NULL,
        [Model] NVARCHAR(100) NOT NULL,
        [Color] NVARCHAR(50) NOT NULL,
        [PlateNumber] NVARCHAR(20) NOT NULL,
        [Year] INT NOT NULL,
        [CreatedAt] DATETIME2 NOT NULL CONSTRAINT DF_Car_CreatedAt DEFAULT (SYSUTCDATETIME()),
        [IsDeleted] BIT NOT NULL CONSTRAINT DF_Car_IsDeleted DEFAULT (0),
        [DeletedAt] DATETIME2 NOT NULL CONSTRAINT DF_Car_DeletedAt DEFAULT ('0001-01-01'),
        CONSTRAINT FK_Car_User FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id])
    );
END
GO

SET NOEXEC OFF;
GO
