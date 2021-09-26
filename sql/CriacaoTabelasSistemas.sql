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

CREATE TABLE [Adresses] (
    [Id] uniqueidentifier NOT NULL,
    [Street] varchar(100) NOT NULL,
    [Number] nvarchar(max) NOT NULL,
    [Complement] nvarchar(max) NOT NULL,
    [Zipcode] nvarchar(max) NULL,
    [Neighborhood] varchar(70) NOT NULL,
    [City] nvarchar(max) NOT NULL,
    [State] int NOT NULL,
    CONSTRAINT [PK_Adresses] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Clients] (
    [Id] uniqueidentifier NOT NULL,
    [Name] varchar(150) NOT NULL,
    [Birthdate] datetime2 NOT NULL,
    [Gender] int NOT NULL,
    [CPF] varchar(11) NOT NULL,
    [Phone] varchar(20) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [IsReceivingInformation] bit NOT NULL,
    [IsVip] bit NOT NULL,
    [RegisterDate] datetime2 NOT NULL,
    [AdressId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Clients_Adresses_AdressId] FOREIGN KEY ([AdressId]) REFERENCES [Adresses] ([Id]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [IX_Clients_AdressId] ON [Clients] ([AdressId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210922154900_Initial', N'5.0.10');
GO

COMMIT;
GO

