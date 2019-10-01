
select 
car.Modelo, --coluna da nossa tabela Carros Modelo
mar.Nome, --coluna da nossa tabela Marcas Nome
car.Placa, --coluna da nossa tabela Carros Placa
car.Ano --coluna da nossa tabela Carros Ano
from --indicador que vamos selecionar uma tabela
Carros car --tabela que vamos utilizar e junta com marcas + abreviação 
inner --indicador que ambas as tabelas devem estar relacionadas com os dados
join --indicador do banco que junta uma tabela e outra
Marcas mar --tabela que vamos juntar com carros + abreviação
on --indicador que vamos mostrar como vamos relacionar as informações 
car.MarcaCodigo = mar.Codigo --aqui informammos que carros tem um codigo igual em marcas e portanto a referencia de marcas seria a coluna codigo
--com isso ele nos tras a linha que temos essa referencia e podemos utilizar todas as colunas da linha com informação