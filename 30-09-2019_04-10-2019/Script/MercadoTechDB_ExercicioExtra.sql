CREATE TABLE [dbo].[Funcionarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Ativo] BIT NULL DEFAULT 1, 
    [UsuarioCriacao] INT NULL DEFAULT 0, 
    [UsuarioAlteracao] INT NULL DEFAULT 0, 
    [DataCriacao] DATETIME NULL DEFAULT getdate(), 
    [DataAlteracao] DATETIME NULL DEFAULT getdate()
)

CREATE TABLE [dbo].[Produtos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Valor] MONEY NOT NULL ,
	[Ativo] BIT NULL DEFAULT 1, 
    [UsuarioCriacao] INT NULL DEFAULT 0, 
    [UsuarioAlteracao] INT NULL DEFAULT 0, 
    [DataCriacao] DATETIME NULL DEFAULT getdate(), 
    [DataAlteracao] DATETIME NULL DEFAULT getdate()

)

CREATE TABLE [dbo].[Pedidos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [FuncionarioId] INT NOT NULL, 
    [ProdutoId] INT NOT NULL, 
    [Quantidade] INT NOT NULL,
	[Ativo] BIT NULL DEFAULT 1, 
    [UsuarioCriacao] INT NULL DEFAULT 0, 
    [UsuarioAlteracao] INT NULL DEFAULT 0, 
    [DataCriacao] DATETIME NULL DEFAULT getdate(), 
    [DataAlteracao] DATETIME NULL DEFAULT getdate()

)

INSERT INTO Funcionarios (Nome) VALUES ('Estefani'),('Bruno')

INSERT INTO Produtos (Nome,Valor) VALUES ('Brahma', 15.0000)
INSERT INTO Produtos (Nome,Valor) VALUES ('Original', 10.0000)
INSERT INTO Produtos (Nome,Valor) VALUES ('Budweiser', 18.0000)
INSERT INTO Produtos (Nome,Valor) VALUES ('H2O', 8.0000)
INSERT INTO Produtos (Nome,Valor) VALUES ('Patagonia', 20.0000)

INSERT INTO Pedidos (FuncionarioId, ProdutoId, Quantidade) VALUES (1, 1, 3)
INSERT INTO Pedidos (FuncionarioId, ProdutoId, Quantidade) VALUES (1, 4, 4)
INSERT INTO Pedidos (FuncionarioId, ProdutoId, Quantidade) VALUES (5, 5, 3)

SELECT * FROM Funcionarios
SELECT * FROM Produtos
SELECT * FROM Pedidos

--Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
SELECT * FROM Funcionarios ORDER BY Nome ASC 

--Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
SELECT * FROM Produtos ORDER BY Valor DESC

--Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario
SELECT ped.Id,fun.Nome,ped.ProdutoId,ped.Quantidade FROM Pedidos ped inner join Funcionarios fun ON ped.FuncionarioId = fun.Id

--Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
SELECT fun.Nome, SUM (ped.Quantidade) AS 'Quantidade de itens' FROM Pedidos ped inner join Funcionarios fun ON ped.FuncionarioId = fun.Id
GROUP BY fun.Nome 

--Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total, lembrando que o valor total é a "quantidade * valor"
SELECT fun.Nome, SUM(ped.Quantidade * pro.Valor) AS 'Valor total pedidos' FROM Pedidos ped inner join Funcionarios fun ON ped.FuncionarioId = fun.Id 
inner join Produtos pro ON ped.ProdutoId = pro.Id GROUP BY fun.Nome

	
--Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
SELECT TOP 1 pro.Nome, SUM(ped.Quantidade) AS 'Quantidade' FROM Produtos pro inner join  Pedidos ped ON pro.Id = ped.ProdutoId 
GROUP BY pro.Nome ORDER BY SUM(ped.Quantidade) DESC


--Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
SELECT TOP 1 pro.Nome, SUM(pro.Valor * ped.Quantidade) AS 'Receita' FROM Produtos pro inner join  Pedidos ped ON pro.Id = ped.ProdutoId 
GROUP BY pro.Nome ORDER BY 'Receita' DESC

--Vamos retornar em uma seleção para o primeiro funcionario, os produtos que ele não comprou de nosso mercado
SELECT * FROM Produtos WHERE Id not in (SELECT ped.ProdutoId FROM Funcionarios fun inner join Pedidos ped ON fun.Id = ped.FuncionarioId
WHERE fun.Nome like 'Estefani%')

--Vamos retornar em uma seleção os produtos ordenados, pela ordem do mais comprado para o menos comprado
SELECT pro.Nome, COUNT(ped.ProdutoId) AS 'Quantidade' FROM Produtos pro left join Pedidos ped ON pro.Id = ped.ProdutoId 
GROUP BY pro.Nome ORDER BY  'Quantidade' DESC