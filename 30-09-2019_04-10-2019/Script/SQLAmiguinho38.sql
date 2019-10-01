create database BaseSistemaLocacao

Go

Use BaseSistemaLocacao

Go

create table Usuarios
(
	 [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NOT NULL,
    [Login]            NCHAR (50)  NOT NULL,
    [Senha]            NCHAR (50)  NOT NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO

create table Marcas
(
	[Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NOT NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO

CREATE TABLE Locacoes
(
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NOT NULL,
    [CarroId]          INT      NOT NULL,
    [Valor]            MONEY    DEFAULT ((0)) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO

CREATE TABLE Carros
(
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo]           NCHAR (50) NOT NULL,
    [MarcaCodigo]      INT        NOT NULL,
    [Placa]            NCHAR (7)  NOT NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    [Ano]              INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO

Insert into Usuarios ([Login], [Nome], [Senha])values ('Admin', 'Administrador', 'Admin')

Insert into Marcas (Codigo, Nome) values (1,'Chevrolet'), (2, 'Ford'), (3, 'Fiat'),( 4, 'Mercedes'),( 5, 'Volkswagem'), (6, 'JAC'),( 7,'Renault'),( 8,'Peugeot')

