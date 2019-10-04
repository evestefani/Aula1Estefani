SELECT * FROM Carros
SELECT * FROM Marcas
SELECT * FROM Usuarios
SELECT * FROM Vendas

--Exercicio 1
UPDATE Marcas SET UsuInc = 1 WHERE UsuInc = 0 




-- Exercicio 2 = Trazer somente as marcas que Felipe ou Giomar cadastrou
SELECT mar.Nome FROM Marcas mar inner join Usuarios usu ON mar.UsuInc = usu.Id
WHERE usu.Usuario like 'Felipe%'

SELECT mar.Nome FROM Marcas mar inner join Usuarios usu ON mar.UsuInc = usu.Id
WHERE usu.Usuario like 'Giomar%'




-- Exercicio 3 = Trazer somente a quantidade de marcas que Felipe ou Giomar cadastrou (maior para menor)
SELECT -- Felipe
COUNT(mar.UsuInc) AS 'Qtd. de Marcas' 
FROM Usuarios usu inner join Marcas mar ON usu.Id = mar.UsuInc WHERE mar.UsuInc = 1
GROUP BY usu.Usuario ORDER BY COUNT(mar.UsuInc) desc

SELECT -- Giomar
COUNT(mar.UsuInc) AS 'Qtd. de Marcas' 
FROM Usuarios usu inner join Marcas mar ON usu.Id = mar.UsuInc WHERE mar.UsuInc = 2
GROUP BY usu.Usuario ORDER BY COUNT(mar.UsuInc) desc




-- Exercicio 4 = Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
SELECT COUNT(mar.UsuInc) AS 'Qtd. de Marcas'
FROM Usuarios usu inner join Marcas mar ON usu.Id = mar.UsuInc WHERE Usuario = 'Felipe' or Usuario = 'Giomar'
GROUP BY usu.Usuario ORDER BY COUNT(mar.UsuInc) DESC




-- Exercicio 5 = Trazer somente os carros que Felipe ou Giomar cadastrou
SELECT car.Modelo, car.Marca 
FROM Carros car inner join Usuarios usu ON car.UsuInc = usu.Id WHERE Usuario like 'Felipe%'

SELECT car.Modelo, car.Marca 
FROM Carros car inner join Usuarios usu ON car.UsuInc = usu.Id WHERE Usuario like 'Giomar%'




-- Exercicio 6 = Trazer somente a quantidade de carros que Felipe ou Giomar cadastrou (maior para menor)
SELECT -- Felipe
COUNT(car.UsuInc) AS 'Qtd. de Carros' 
FROM Usuarios usu inner join Carros car ON usu.Id = car.UsuInc WHERE car.UsuInc = 1
GROUP BY usu.Usuario ORDER BY COUNT(car.UsuInc) DESC

SELECT -- Giomar
COUNT(car.UsuInc) AS 'Qtd. de Carros' 
FROM Usuarios usu inner join Carros car ON usu.Id = car.UsuInc WHERE car.UsuInc = 2
GROUP BY usu.Usuario ORDER BY COUNT(car.UsuInc) ASC




-- Exercicio 7 = Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
SELECT COUNT(car.UsuInc) AS 'Qtd. de Carros'
FROM Usuarios usu inner join Carros car ON usu.Id = car.UsuInc  WHERE Usuario = 'Felipe' or Usuario = 'Giomar'
group by usu.Usuario ORDER BY COUNT(car.UsuInc) DESC




-- Exercicio 8 = Trazer o valor total de vendas 2019 isolado
            -- = Trazer a quantidade total de vendas 2019 isolado

SELECT SUM (vend.Valor * vend.Quantidade) AS 'Total de 2019' 
FROM Vendas vend WHERE vend.DatInc between '01/01/2019'and'12/31/2019'

SELECT COUNT (vend.Quantidade) AS 'Total de 2019' 
FROM Vendas vend WHERE vend.DatInc between '01/01/2019'and'12/31/2019'




-- Exercicio 9 = Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
            -- = Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
           			
SELECT YEAR(DatInc) as 'Ano', SUM(Valor*Quantidade) as 'Total'
FROM Vendas GROUP BY YEAR (DatInc) ORDER BY SUM(Valor*Quantidade) DESC

SELECT YEAR(DatInc) as 'Ano', COUNT(Quantidade) as 'Total'
FROM Vendas GROUP BY YEAR (DatInc) ORDER BY COUNT(Quantidade) DESC




-- Exercicio 10 = Trazer o mês de cada ano que retornou a maior quantidade de vendas
             -- = Trazer o mês de cada ano que retornou o maior valor de vendas

SELECT YEAR(ven1.DatInc) AS 'Ano',(SELECT TOP 1 MONTH(ven.DatInc)
FROM Vendas ven WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc)
GROUP BY MONTH(ven.DatInc) ORDER BY SUM(ven.Quantidade) DESC)
FROM Vendas ven1 GROUP BY YEAR(ven1.DatInc)

SELECT YEAR(ven1.DatInc) AS 'Ano',(SELECT TOP 1 MONTH(ven.DatInc)
FROM Vendas ven WHERE YEAR(ven.DatInc) = YEAR(ven1.DatInc)
GROUP BY MONTH(ven.DatInc) ORDER BY SUM(ven.Quantidade*ven.Valor) DESC)
FROM Vendas ven1 GROUP BY YEAR(ven1.DatInc)




-- Exercicio 11 = Trazer o valor total de vendas que Felipe ou Giomar realizou

SELECT SUM(vend.Valor * vend.Quantidade) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Felipe%'

SELECT SUM(vend.Valor * vend.Quantidade) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Giomar%'




-- Exercicio 12 = Trazer a quantidade total de vendas que Felipe ou Giomar realizou

SELECT COUNT(vend.Valor) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Felipe%'

SELECT SUM(vend.Valor) FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id  WHERE Usuario like 'Giomar%'




-- Exercicio 13 = Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
             -- = Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor

SELECT COUNT(vend.Valor) AS 'Qtd. total de vendas' FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id WHERE Usuario = 'Felipe' or Usuario = 'Giomar'
GROUP BY (usu.Usuario) ORDER BY COUNT (vend.Valor) DESC

SELECT SUM(vend.Valor*Quantidade) AS 'Total de vendas' FROM Vendas vend inner join Usuarios usu ON vend.UsuInc = usu.Id WHERE Usuario = 'Felipe' or Usuario = 'Giomar'
GROUP BY (usu.Usuario) ORDER BY SUM (vend.Valor*Quantidade) DESC


-- Exercicio 14 = Trazer as marcas mais vendidas de todos os anos
		     -- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
             -- = Trazer o valor total da marca mais vendida de todos os anos

SELECT mar.Nome AS 'Marcas mais vendidas'
FROM Marcas mar
inner join Carros car ON car.Marca = mar.Id
inner join Vendas vend ON vend.Carro = car.Id
GROUP BY mar.Nome 
ORDER BY SUM(vend.Quantidade) DESC


SELECT SUM(vend.Valor * vend.Quantidade) AS 'Valor total das marcas mais vendidas'
FROM Marcas mar
inner join Carros car ON car.Marca = mar.Id
inner join Vendas vend ON vend.Carro = car.Id
GROUP BY mar.Nome 
ORDER BY SUM(vend.Valor * vend.Quantidade) DESC




-- Exercicio 15 = Trazer a quantidade do carro mais vendido de todos os anos
             -- = Trazer o valor do carro mais vendido de todos os anos

SELECT car.Modelo, SUM(vend.Quantidade) AS 'Quantidade do carro mais vendido'
FROM Vendas vend
inner join Carros car ON vend.Carro = car.Id
GROUP BY car.Modelo 
ORDER BY SUM(vend.Quantidade) DESC


SELECT AVG(vend.Valor) AS 'Valor do carro mais vendido'
FROM Carros car
inner join Vendas vend ON vend.Carro = car.Id
GROUP BY car.Modelo 
ORDER BY SUM(vend.Quantidade) DESC

