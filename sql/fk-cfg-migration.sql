IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Enderecos] (
    [Id] uniqueidentifier NOT NULL,
    [Cep] varchar(8) NOT NULL,
    [Logradouro] varchar(200) NOT NULL,
    [Numero] varchar(50) NOT NULL,
    [Complemento] varchar(100) NOT NULL,
    [Bairro] varchar(100) NOT NULL,
    [Municipio] varchar(100) NOT NULL,
    [uf] varchar(2) NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Telefones] (
    [Id] uniqueidentifier NOT NULL,
    [Tipo] varchar(15) NOT NULL,
    [Numero] varchar(11) NOT NULL,
    CONSTRAINT [PK_Telefones] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Pessoas] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] varchar(200) NOT NULL,
    [Cpf] varchar(11) NOT NULL,
    [Rg] varchar(10) NOT NULL,
    [TelefoneId] uniqueidentifier NULL,
    [EnderecoId] uniqueidentifier NULL,
    CONSTRAINT [PK_Pessoas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pessoas_Enderecos_EnderecoId] FOREIGN KEY ([EnderecoId]) REFERENCES [Enderecos] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Pessoas_Telefones_TelefoneId] FOREIGN KEY ([TelefoneId]) REFERENCES [Telefones] ([Id]) ON DELETE NO ACTION
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bairro', N'Cep', N'Complemento', N'Logradouro', N'Municipio', N'Numero', N'uf') AND [object_id] = OBJECT_ID(N'[Enderecos]'))
    SET IDENTITY_INSERT [Enderecos] ON;
INSERT INTO [Enderecos] ([Id], [Bairro], [Cep], [Complemento], [Logradouro], [Municipio], [Numero], [uf])
VALUES ('9ce65e5a-2f18-48ef-8536-8fe44f238b7d', 'Centro', '20260525', 'casa 23', 'Rua Sete de Setembro', 'Rio de Janeiro', '15', 'RJ'),
('9e954313-7187-4a90-b7b6-ef8d56d55f4d', 'Centro', '11260525', 'bloco 6 ap 306', 'Avenida Paulista', 'São Paulo', '1205', 'SP'),
('53c168cc-4dff-4a15-84bd-736f543e860a', 'Bangu', '21280525', 'casa 5', 'Avenida Ministro Ary Franco', 'Rio de Janeiro', '2255', 'RJ');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bairro', N'Cep', N'Complemento', N'Logradouro', N'Municipio', N'Numero', N'uf') AND [object_id] = OBJECT_ID(N'[Enderecos]'))
    SET IDENTITY_INSERT [Enderecos] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'EnderecoId', N'Nome', N'Rg', N'TelefoneId') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
    SET IDENTITY_INSERT [Pessoas] ON;
INSERT INTO [Pessoas] ([Id], [Cpf], [EnderecoId], [Nome], [Rg], [TelefoneId])
VALUES ('b8cecb08-a52e-4e4b-bba4-7466177e10fc', '111548', NULL, 'Herb Hancock', '21514151', NULL),
('aa2c742b-7063-409f-89a4-4e46f4583444', '1252632545', NULL, 'Chick Corea', '207255136', NULL),
('628cf453-007c-4618-aacb-068403c15535', '111548', NULL, 'Charlie Parker', '153526548', NULL);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'EnderecoId', N'Nome', N'Rg', N'TelefoneId') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
    SET IDENTITY_INSERT [Pessoas] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Numero', N'Tipo') AND [object_id] = OBJECT_ID(N'[Telefones]'))
    SET IDENTITY_INSERT [Telefones] ON;
INSERT INTO [Telefones] ([Id], [Numero], [Tipo])
VALUES ('96c33fe8-8b66-462a-9dc1-7148dd12fe57', '985635241', 'Celular'),
('c0f4cc2c-d31d-492f-8636-6e35467ffb5b', '975859654', 'Celular'),
('62c9af28-d520-4375-918f-447b8dce14dc', '312524684', 'Fixo');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Numero', N'Tipo') AND [object_id] = OBJECT_ID(N'[Telefones]'))
    SET IDENTITY_INSERT [Telefones] OFF;

GO

CREATE INDEX [IX_Pessoas_EnderecoId] ON [Pessoas] ([EnderecoId]);

GO

CREATE INDEX [IX_Pessoas_TelefoneId] ON [Pessoas] ([TelefoneId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210224003618_InitialMigration', N'3.1.12');

GO

ALTER TABLE [Pessoas] DROP CONSTRAINT [FK_Pessoas_Enderecos_EnderecoId];

GO

ALTER TABLE [Pessoas] DROP CONSTRAINT [FK_Pessoas_Telefones_TelefoneId];

GO

DROP INDEX [IX_Pessoas_EnderecoId] ON [Pessoas];

GO

DROP INDEX [IX_Pessoas_TelefoneId] ON [Pessoas];

GO

DELETE FROM [Enderecos]
WHERE [Id] = '53c168cc-4dff-4a15-84bd-736f543e860a';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Enderecos]
WHERE [Id] = '9ce65e5a-2f18-48ef-8536-8fe44f238b7d';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Enderecos]
WHERE [Id] = '9e954313-7187-4a90-b7b6-ef8d56d55f4d';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Pessoas]
WHERE [Id] = '628cf453-007c-4618-aacb-068403c15535';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Pessoas]
WHERE [Id] = 'aa2c742b-7063-409f-89a4-4e46f4583444';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Pessoas]
WHERE [Id] = 'b8cecb08-a52e-4e4b-bba4-7466177e10fc';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Telefones]
WHERE [Id] = '62c9af28-d520-4375-918f-447b8dce14dc';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Telefones]
WHERE [Id] = '96c33fe8-8b66-462a-9dc1-7148dd12fe57';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Telefones]
WHERE [Id] = 'c0f4cc2c-d31d-492f-8636-6e35467ffb5b';
SELECT @@ROWCOUNT;


GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pessoas]') AND [c].[name] = N'EnderecoId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Pessoas] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Pessoas] DROP COLUMN [EnderecoId];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pessoas]') AND [c].[name] = N'TelefoneId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Pessoas] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Pessoas] DROP COLUMN [TelefoneId];

GO

CREATE TABLE [EnderecoPessoa] (
    [Id] uniqueidentifier NOT NULL,
    [PessoaId] uniqueidentifier NOT NULL,
    [PessoaForeignKey] uniqueidentifier NOT NULL,
    [Cep] int NOT NULL,
    [Logradouro] nvarchar(max) NULL,
    [Numero] int NOT NULL,
    [Complemento] nvarchar(max) NULL,
    [Bairro] nvarchar(max) NULL,
    [Municipio] nvarchar(max) NULL,
    [uf] nvarchar(max) NULL,
    CONSTRAINT [PK_EnderecoPessoa] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EnderecoPessoa_Pessoas_PessoaForeignKey] FOREIGN KEY ([PessoaForeignKey]) REFERENCES [Pessoas] ([Id]) ON DELETE CASCADE
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bairro', N'Cep', N'Complemento', N'Logradouro', N'Municipio', N'Numero', N'uf') AND [object_id] = OBJECT_ID(N'[Enderecos]'))
    SET IDENTITY_INSERT [Enderecos] ON;
INSERT INTO [Enderecos] ([Id], [Bairro], [Cep], [Complemento], [Logradouro], [Municipio], [Numero], [uf])
VALUES ('8da9fd2c-0c15-49dc-9db5-510e1234df80', 'Centro', '20260525', 'casa 23', 'Rua Sete de Setembro', 'Rio de Janeiro', '15', 'RJ'),
('e2605fac-e00f-4da9-b7c3-491a9c6379a9', 'Centro', '11260525', 'bloco 6 ap 306', 'Avenida Paulista', 'São Paulo', '1205', 'SP'),
('53a73f88-a377-4e5e-9320-52e362ebecea', 'Bangu', '21280525', 'casa 5', 'Avenida Ministro Ary Franco', 'Rio de Janeiro', '2255', 'RJ');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Bairro', N'Cep', N'Complemento', N'Logradouro', N'Municipio', N'Numero', N'uf') AND [object_id] = OBJECT_ID(N'[Enderecos]'))
    SET IDENTITY_INSERT [Enderecos] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'Nome', N'Rg') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
    SET IDENTITY_INSERT [Pessoas] ON;
INSERT INTO [Pessoas] ([Id], [Cpf], [Nome], [Rg])
VALUES ('8b2f7e4a-930d-4702-899d-18db38140cfd', '111548', 'Herb Hancock', '21514151'),
('78020c1a-7ba1-4aa5-841e-28f2767498e2', '1252632545', 'Chick Corea', '207255136'),
('1ec2f34f-34b2-40ed-a326-ba37c71dea22', '111548', 'Charlie Parker', '153526548');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'Nome', N'Rg') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
    SET IDENTITY_INSERT [Pessoas] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Numero', N'Tipo') AND [object_id] = OBJECT_ID(N'[Telefones]'))
    SET IDENTITY_INSERT [Telefones] ON;
INSERT INTO [Telefones] ([Id], [Numero], [Tipo])
VALUES ('662e9883-9ed6-47a7-a500-a82111440cb6', '985635241', 'Celular'),
('590f1e4f-f2bf-4152-8cc7-30f86df878c0', '975859654', 'Celular'),
('522f650a-a701-425c-b5fa-c54167df56eb', '312524684', 'Fixo');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Numero', N'Tipo') AND [object_id] = OBJECT_ID(N'[Telefones]'))
    SET IDENTITY_INSERT [Telefones] OFF;

GO

CREATE UNIQUE INDEX [IX_EnderecoPessoa_PessoaForeignKey] ON [EnderecoPessoa] ([PessoaForeignKey]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210224032302_FKConfiguration', N'3.1.12');

GO

