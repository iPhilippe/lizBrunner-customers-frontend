IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clients] (
    [Id] uniqueidentifier NOT NULL,
    [Name] varchar(150) NOT NULL,
    [Birthdate] datetime2 NOT NULL,
    [Gender] int NOT NULL,
    [CPF] varchar(11) NOT NULL,
    [Phone] varchar(20) NOT NULL,
    [Email] varchar(150) NOT NULL,
    [IsReceivingInformation] bit NOT NULL,
    [IsVip] bit NOT NULL,
    [RegisterDate] datetime2 NOT NULL,
    [Street] varchar(100) NOT NULL,
    [Number] varchar(150) NOT NULL,
    [Complement] varchar(70) NULL,
    [Zipcode] varchar(150) NOT NULL,
    [Neighborhood] varchar(70) NOT NULL,
    [City] varchar(150) NOT NULL,
    [State] int NOT NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211010205600_Initial', N'5.0.9');
GO

COMMIT;
GO

