CREATE TABLE [dbo].[Carros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Modelo] NCHAR(50) NULL, 
    [Marca] NCHAR(50) NULL, 
    [Placa] NCHAR(7) NULL, 
    [Ano] INT NULL, 
    [Ativo] BIT NULL DEFAULT 1, 
    [UsuarioCriacao] INT NULL DEFAULT 0, 
    [UsuarioAlteracao] INT NULL DEFAULT 0, 
    [DataCriacao] DATETIME NULL DEFAULT GETDATE(), 
    [DataAlteracao] DATETIME NULL DEFAULT GETDATE()
)
