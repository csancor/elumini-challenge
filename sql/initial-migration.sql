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

