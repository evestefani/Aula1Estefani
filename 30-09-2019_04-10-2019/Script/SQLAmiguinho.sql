CREATE DATABASE BaseSistemaLocacao
GO
USE BaseSistemaLocacao
GO

CREATE TABLE [dbo].[Usuarios]
(
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO

INSERT INTO Usuarios ([Nome], [Login], [Senha])
VALUES
('Administrador','admin','admin')

GO

CREATE TABLE [dbo].[Carros]
(
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo]           NCHAR (50) NULL,
    [MarcaCodigo]      INT        NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano]              INT        NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO

SET IDENTITY_INSERT [dbo].[Carros] ON
INSERT INTO [dbo].[Carros] ([Id], [Modelo], [MarcaCodigo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (1, N'Fusca                                             ', 1, N'MDF8989', 1963, 1, 1, 1, N'2019-10-01 09:14:54', N'2019-10-01 09:14:54')
INSERT INTO [dbo].[Carros] ([Id], [Modelo], [MarcaCodigo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (2, N'Ranger                                            ', 2, N'MGH1234', 1998, 1, 2, 2, N'2019-10-01 09:15:18', N'2019-10-01 09:15:18')
INSERT INTO [dbo].[Carros] ([Id], [Modelo], [MarcaCodigo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (3, N'Chevette                                          ', 3, N'MLF3574', 1982, 1, 3, 3, N'2019-10-01 09:15:44', N'2019-10-01 09:15:44')
INSERT INTO [dbo].[Carros] ([Id], [Modelo], [MarcaCodigo], [Placa], [Ano], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (4, N'Golf                                              ', 1, N'MSE1789', 2018, 1, 2, 3, N'2019-10-01 00:00:00', N'2019-10-02 00:00:00')
SET IDENTITY_INSERT [dbo].[Carros] OFF

GO

CREATE TABLE [dbo].[Locações]
(
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioID]        INT      NULL,
    [CarroID]          INT      NULL,
    [Valor]            MONEY    NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO

SET IDENTITY_INSERT [dbo].[Locações] ON
INSERT INTO [dbo].[Locações] ([Id], [UsuarioID], [CarroID], [Valor], [DataInicial], [DataDevolucao], [Ativo], [UsuarioCriacao], [UsuarioAlteracao], [DataCriacao], [DataAlteracao]) VALUES (1005, 3, 2, CAST(150.0000 AS Money), N'2019-10-01 09:28:51', N'2019-10-06 09:28:51', 1, 1, 1, N'2019-10-01 09:28:51', N'2019-10-01 09:28:51')
SET IDENTITY_INSERT [dbo].[Locações] OFF

GO

CREATE TABLE [dbo].[Marcas]
(
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

SET IDENTITY_INSERT [dbo].[Marcas] ON
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (1, 1, N'Volkswagen          ')
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (2, 2, N'Ford                ')
INSERT INTO [dbo].[Marcas] ([Id], [Codigo], [Nome]) VALUES (3, 3, N'Chevrolet           ')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
