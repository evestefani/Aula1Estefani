CREATE TABLE [dbo].[Usuarios] (
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome ]            NCHAR (100) NULL,
    [Login]            NCHAR (50)  NOT NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

