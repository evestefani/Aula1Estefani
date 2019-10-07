select * from Marcas
select * from Carros

select Modelo,
(select Nome from Marcas where Codigo = MarcaCodigo) as 'Marca', 
Placa, 
Ano
from Carros where MarcaCodigo = 1