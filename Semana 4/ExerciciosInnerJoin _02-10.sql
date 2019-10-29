
INSERT INTO Clientes VALUES ('Estefani',1,31,1,0,0,'10/02/2019','10/02/2019');
INSERT INTO Clientes VALUES ('Camila',1,37,1,0,0,'10/02/2019','10/02/2019');
INSERT INTO Clientes VALUES ('Elia',1,54,1,0,0,'10/02/2019','10/02/2019');
INSERT INTO Clientes VALUES ('Bruno',2,30,1,0,0,'10/02/2019','10/02/2019');

SELECT * FROM Clientes;

INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000001',2,379.44);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000002',2,654.59);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000003',2,469.33);

INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000004',5,45.23);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000005',5,76.12);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000006',5,149.32);

INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000007',6,179.22);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000008',6,300.00);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000009',6,10.23);

INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000010',7,753.33);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000011',7,78.90);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N0000012',7,65.44);

SELECT * FROM Pedidos;


/*EXEMPLOS DE FILTROS*/

/*SELECT que junta as duas tabelas trazendo todas as informações delas, neste caso ainda filtrando as informações por nome, valor, id, etc... pelo where*/
SELECT -- Iniciando o select
ped. * -- Aqui temos todas as colunas de nossa tabela pedidos apenas
FROM Pedidos ped -- Seleção da massa tabela de pedidos
inner join -- Terminador SQL que junta as duas informações
Clientes cli on ped.ClienteId = cli.Id -- Validamos o que conecta as informações
where cli.Nome = 'Estefani' -- Aqui aplicamos um filtro para estas informações

/*SELECT que junta as duas tabelas trazendo todas as informações delas já efetuando a soma dos valores, neste caso ainda filtrado pelo cliente pelo where*/
SELECT SUM(ped.Valor) FROM Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id where cli.Nome = 'Estefani'

/*SELECT que junta as duas tabelas trazendo todas as informações delas já efetuando a soma dos valores, assim podendo dizer se o valor lhe dará o direito de ganhar um brinde e neste caso ainda filtrado pelo cliente pelo where para saber o valor total*/
SELECT -- Iniciando o select
IIF -- Iniciamos um if dentro de um select, o mesmo pode mostrar 
(SUM(ped.Valor) -- Somamos os valores do pedido de cada pedido do nosso cliente que temos em nossa base
> 2000, -- Aplicamos uma regra para o sorteo do nosso brinde
'Brinde Xiaomi', -- Caso positivo temos o brinde
'Não ganhou nada') -- Caso valor negativo não temos brinde
as 'Resultado', -- Damos um nome ao nosso resultado
SUM(ped.Valor) as 'Total' -- Aqui apresentamos o valor total do pedido
FROM Pedidos  ped -- Tabela de pedidos 
inner join Clientes cli on ped.ClienteId = cli.Id -- Inner join e nossas validações para as relações
where cli.Nome = 'Estefani' -- Nosso filtro

/*SELECT que junta as duas tabelas trazendo todas as informações delas já efetuando a soma dos valores, assim podendo dizer se o valor lhe dará o direito que ganhar um brinde e neste caso ainda agrupando os valores por cliente para saber quem ganhou e quem não*/
SELECT IIF (SUM(ped.Valor) > 2000, 'Brinde Xiaomi', 'Não ganhou nada') as 'Resultado', SUM(ped.Valor) as 'Total', cli.Nome FROM Pedidos  ped inner join Clientes cli on ped.ClienteId = cli.Id GROUP BY cli.Nome -- ao remover o where  e apresentar todos os valores tremos o 
                                                                                                                                                                                                                 -- group by, junta as informações pelo campo que estamos informando

/*SELECT que junta as duas tabelas trazendo todas as informações delas já efetuando a soma dos valores, assim podendo dizer se o valor lhe dará o direito que ganhar um brinde e neste caso ainda agrupando os valores por cliente para saber quem ganhou e quem não*/
SELECT IIF (SUM(ped.Valor) > 2000, 'Brinde Xiaomi', 'Não ganhou nada') as 'Resultado', SUM(ped.Valor) as 'Total', cli.Nome FROM Clientes cli inner join Pedidos ped on cli.Id = ped.ClienteId GROUP BY cli.Nome -- ao remover o where  e apresentar todos os valores tremos o 
                                                                                                                                                                                                                -- group by, junta as informações pelo campo que estamos informando

/*SELECT que junta as duas tabelas somente com as informações escolhidas abaixo*/
SELECT ped.ClientEId, cli.Nome,ped.Numero, ped.Valor, ped.DataCriacao, ped.DataAlteracao from Pedidos ped
inner join Clientes cli on ped.ClienteId = cli.Id

/*SELECT que ordena os pedidos por ordem de valor*/
SELECT * FROM Pedidos order by Valor asc


/*PROCESSO INVERSO*/

/*SELECT que juntas as informações das duas tabelas onde informando apenas uma informação (neste caso o numero do pedido) ele trará as demais informações daquele ID, ordenando ainda pelo maior valor*/
SELECT * FROM Pedidos ped
WHERE ped.ClienteId in 
(SELECT cli.Id FROM Clientes cli inner join Pedidos ped on cli.Id = ped.ClienteId where ped.Numero in ('N0000001', 'N0000005','N0000010')) order by ped.Valor desc;