CREATE TABLE [dbo].[Funcionarios] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (50) NOT NULL,
    [DataInicio]       DATE   DEFAULT (getdate()) NOT NULL,
    [DataSaida]        DATE   DEFAULT (getdate()) NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

