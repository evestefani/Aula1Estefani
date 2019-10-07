CREATE TABLE [dbo].[Flores]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nome] NVARCHAR(30) NULL, 
    [Quantidade] INT NULL,

)

INSERT INTO Flores (Nome,Quantidade) VALUES ('Rosa', 5)
INSERT INTO Flores (Nome,Quantidade) VALUES ('Cravo', 3)
INSERT INTO Flores (Nome,Quantidade) VALUES ('Margarida', 2)
INSERT INTO Flores (Nome,Quantidade) VALUES ('Orquidea', 7)
INSERT INTO Flores (Nome,Quantidade) VALUES ('Lirio', 3)

--Ordenar a ordem das flores da mior para menor quantidade
SELECT * FROM Flores ORDER BY Quantidade DESC

--Fazer a soma total da quantidade de flores
SELECT COUNT(*) AS 'Qtd. total de flores' FROM Flores 
--O asterisco (*) significa que puxa todas as colunas