SELECT * FROM Carros
SELECT * FROM Marcas
SELECT * FROM Usuarios
SELECT * FROM Vendas

--Exercicio 1
UPDATE Marcas SET UsuInc = 1 WHERE UsuInc = 0 


-- Exercicio 2
SELECT mar.Nome FROM Marcas mar inner join Usuarios usu ON mar.UsuInc = usu.Id
WHERE usu.Usuario like 'Felipe%'

SELECT mar.Nome FROM Marcas mar inner join Usuarios usu ON mar.UsuInc = usu.Id
WHERE usu.Usuario like 'Giomar%'


-- Exercicio 3
SELECT -- Felipe
COUNT(mar.UsuInc) AS 'Qtd. de Marcas' 
FROM Usuarios usu inner join Marcas mar on usu.Id = mar.UsuInc where mar.UsuInc = 1
group by usu.Usuario ORDER BY COUNT(mar.UsuInc) desc

SELECT -- Giomar
COUNT(mar.UsuInc) AS 'Qtd. de Marcas' 
FROM Usuarios usu inner join Marcas mar on usu.Id = mar.UsuInc where mar.UsuInc = 2
group by usu.Usuario ORDER BY COUNT(mar.UsuInc) desc


-- Exercicio 4
/*SELECT
COUNT(mar.UsuInc) AS 'Qtd. de Marcas'
FROM Usuarios usu inner join Marcas mar on usu.Id = mar.UsuInc  where usu.Id between 1 and 2
group by usu.Usuario ORDER BY COUNT(mar.UsuInc) desc*/


-- Exercicio 5
SELECT car.Modelo, car.Marca -- Felipe
FROM Carros car inner join Usuarios usu on car.UsuInc = usu.Id where Usuario like 'Felipe%'

SELECT car.Modelo, car.Marca -- Giomar
FROM Carros car inner join Usuarios usu on car.UsuInc = usu.Id where Usuario like 'Giomar%'


-- Exercicio 6
SELECT -- Felipe
COUNT(car.UsuInc) AS 'Qtd. de Carros' 
FROM Usuarios usu inner join Carros car on usu.Id = car.UsuInc where car.UsuInc = 1
group by usu.Usuario ORDER BY COUNT(car.UsuInc) desc

SELECT -- Giomar
COUNT(car.UsuInc) AS 'Qtd. de Carros' 
FROM Usuarios usu inner join Carros car on usu.Id = car.UsuInc where car.UsuInc = 2
group by usu.Usuario ORDER BY COUNT(car.UsuInc) asc


-- Exercicio 7
/*SELECT
COUNT(car.UsuInc) AS 'Qtd. de Carros'
FROM Usuarios usu inner join Carros car on usu.Id = car.UsuInc  where usu.Id between 1 and 2
group by usu.Usuario ORDER BY COUNT(car.UsuInc) desc*/


-- Exercicio 8
SELECT SUM (vend.Valor * vend.Quantidade) AS 'Total de 2019' 
FROM Vendas vend WHERE vend.DatInc between '01/01/2019'and'12/31/2019'

SELECT COUNT (vend.Quantidade) AS 'Total de 2019' 
FROM Vendas vend WHERE vend.DatInc between '01/01/2019'and'12/31/2019'

-- Exercicio 9
SELECT YEAR(DatInc) as 'Ano', SUM(Valor*Quantidade) as 'Total'
FROM Vendas GROUP BY YEAR (DatInc) ORDER BY SUM(Valor*Quantidade) desc

SELECT YEAR(DatInc) as 'Ano', COUNT(Quantidade) as 'Total'
FROM Vendas GROUP BY YEAR (DatInc) ORDER BY COUNT(Quantidade) desc

-- Exercicio 10

SELECT TOP 3 YEAR(DatInc) AS 'Ano', SUM(Quantidade) AS 'Quantidade', MONTH(DatInc) AS 'Mês'
FROM Vendas GROUP BY YEAR (DatInc), MONTH(DatInc) ORDER BY SUM(Quantidade) desc

SELECT TOP 3 YEAR(DatInc) AS 'Ano', SUM(Valor*Quantidade) AS 'Quantidade', MONTH(DatInc) AS 'Mês'
FROM Vendas GROUP BY YEAR (DatInc), MONTH(DatInc) ORDER BY SUM(Valor*Quantidade) desc

-- Exercicio 11

SELECT SUM(vend.Valor * vend.Quantidade) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Felipe%'

SELECT SUM(vend.Valor * vend.Quantidade) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Giomar%'

-- Exercicio 12

SELECT SUM(vend.Quantidade) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Felipe%'

SELECT SUM(vend.Quantidade) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Giomar%'


-- Exercicio 13
/*SELECT
COUNT(car.UsuInc) AS 'Qtd. de Carros'
FROM Usuarios usu inner join Carros car on usu.Id = car.UsuInc  where usu.Id between 1 and 2
group by usu.Usuario ORDER BY COUNT(car.UsuInc) desc*/


-- Exercicio 14
