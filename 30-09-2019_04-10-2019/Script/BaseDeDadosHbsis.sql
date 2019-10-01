CREATE DATABASE BaseDeDadosHbsis

GO

USE BaseDeDadosHbsis

GO

CREATE TABLE [dbo].[Usuarios] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (50) NULL,
    [Login]            NCHAR (20) NULL,
    [Senha]            NCHAR (10) NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[Marcas] (
    [Id]          INT        NOT NULL,
    [Codigo]      INT        NULL,
    [NomeDaMarca] NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[VeiculoDoUsuario] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [IdDoUsuario]      INT        NULL,
    [MarcasCodigo]     INT        NULL,
    [Modelo]           NCHAR (20) NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO

CREATE TABLE [dbo].[Locacao] (
    [Id]                 INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioID]          INT      NULL,
    [VeiculoDoUsuarioID] INT      NULL,
    [Valor]              MONEY    NULL,
    [DataLocacao]        DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]      DATETIME DEFAULT (dateadd(month, (6), getdate())) NULL,
    [Ativo]              BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]     INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao]   INT      DEFAULT ((0)) NULL,
    [DataCriacao]        DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]      DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



