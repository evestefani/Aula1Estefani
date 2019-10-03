/*Exmeplo de update de alguma informação*/
--UPDATE Funcionarios SET Ativo = 1

SELECT * FROM Salarios ORDER BY DataCriacao ASC -- Ordena os salarios por ordem de data de pagamento

SELECT 
sal.FuncionarioId AS 'Id',
func.Nome AS 'Nome', 
func.DataInicio,
sal.Valor,
sal.Datacriacao AS 'Data do pagamento' 
FROM Salarios sal inner join Funcionarios func on sal.FuncionarioId = func.Id

/*SELECT que soma o total de salario de cada funcionario - cuidar com subquerys*/
SELECT Nome,
(SELECT SUM(Valor) FROM Salarios WHERE FuncionarioId = Funcionarios.Id) FROM Funcionarios

/*SELECT que soma o total de salario de cada funcionario, feito da maneira correta*/
SELECT func.Nome, 
SUM(sal.Valor) AS 'Total no 3 meses' FROM Funcionarios func inner join Salarios sal on func.Id = sal.FuncionarioId
GROUP BY func.Nome

/*SELECT que tira a media de salario de cada funcionario e com o count que dira quantos pagamentos foram efetuados*/
SELECT func.Nome, 
AVG(sal.Valor) AS 'Media no 3 meses',
COUNT(sal.Valor) AS 'Qtd. de Pagamentos' 
FROM Funcionarios func inner join Salarios sal on func.Id = sal.FuncionarioId
GROUP BY func.Nome

/*SELECT que tira a media de salario de cada funcionario e com o count que dira quantos pagamentos foram efetuados, logo abaixo uma nova forma de tirar a media tambem e apresentando o total*/
SELECT func.Nome, 
AVG(sal.Valor) AS 'Media no 3 meses',
COUNT(sal.Valor) AS 'Qtd. de Pagamentos',
SUM(sal.Valor) / COUNT(sal.Valor) AS 'Nova media',
SUM(sal.Valor) AS 'Total'
FROM Funcionarios func inner join Salarios sal on func.Id = sal.FuncionarioId
GROUP BY func.Nome
ORDER BY SUM(sal.Valor) ASC

/*SELECT que dará somente os registros entre os ID informados abaixo*/
SELECT * FROM Salarios
WHERE Id BETWEEN 3 AND 8

/*SELECT que dará somente os registros entre as respectivas datas abaixo*/
SELECT * FROM Salarios
WHERE DataCriacao BETWEEN '07/05/2019' AND '08/07/2019'

/*SELECT que dará os 5 maiores salarios*/
SELECT TOP 5 * FROM Salarios ORDER BY Valor DESC

/*SELECT */
SELECT * FROM Salarios WHERE Id >= 3 and Id <= 8

/*Exemplo de updtae no caso de data de demissao*/
UPDATE Funcionarios SET DataSaida = '09/09/2020',
DataAlteracao = GETDATE(), Ativo = 0
WHERE Nome LIKE 'Bruno%' --% é usado para trazer todas as palavras que comecem com a letra ou silaba espicificada, 
--neste caso esta no final da palavra então ele trará as letras ou silabas iniciais das palavras, 
--se estiver no começo ira filtrar pelas letras finais da palavra...


/*SELECT que converte a data no padrão correto - pt-br*/
SELECT 
Nome,
CONVERT (VARCHAR(10),DataInicio, 103) AS 'Inicio',
CONVERT (VARCHAR(10),DataSaida, 103) AS 'Saida'
FROM Funcionarios

