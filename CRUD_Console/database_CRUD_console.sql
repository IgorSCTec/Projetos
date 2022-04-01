USE [TesteCadastro]

CREATE TABLE [Cliente] (
    [Id] uniqueidentifier NOT NULL DEFAULT NEWID(),
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Phone] NVARCHAR(20) NULL,
    [Birthdate] DATETIME NULL,
    [CreateDate] DATETIME NOT NULL
);
GO

