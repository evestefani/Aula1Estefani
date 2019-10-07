CREATE DATABASE BaseDeDadosHbsis
GO
USE BaseDeDadosHbsis
GO
CREATE TABLE [dbo].[Tipos] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Codigo] INT           NULL,
    [Nome]   NVARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Marcas] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Codigo]      INT           NULL,
    [Nome]        NVARCHAR (20) NULL,
    [TiposCodigo] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Veiculos] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Descricao]    NVARCHAR (30) NULL,
    [MarcasCodigo] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
INSERT INTO Tipos (Codigo,Nome) -- Insert das informações de Tipos
values (1,'Carro'),(2,'Moto') 
GO
INSERT INTO Marcas (Codigo,Nome,TiposCodigo) -- Insert das informações de Marcas
values (1,'BMW',1),(2,'BMW',2),(3,'KIA',1),(4,'KAWASAKI',2)
GO
INSERT INTO Veiculos (Descricao,MarcasCodigo) -- Insert das informações de Vericulos
values ('M6',1),('R 1200',2),('Besta',3),('Sportage',3),('Z 900',4),('Z 1000',4)
GO
--MOTO
SELECT * FROM Tipos
GO
--MARCAS
SELECT * FROM MARCAS
GO
--MOTOS - VECULOS
SELECT * FROM Veiculos
GO
--Select super bonus
SELECT
veic.Id,
veic.Descricao,
mar.Nome AS 'Marca',
tip.Nome AS 'Tipo'
FROM Veiculos veic 
inner join Marcas mar ON veic.MarcasCodigo = mar.Codigo
inner join Tipos tip ON mar.TiposCodigo = tip.Codigo
WHERE mar.Codigo = 4 -- Kawasaki
-- OU --
WHERE mar.Codigo = 3 -- KIA