
select veic.Modelo, mar.NomeDaMarca, veic.Placa
from VeiculoDoUsuario veic inner join Marcas mar on veic.MarcasCodigo = mar.Codigo 
where mar.Codigo = 3