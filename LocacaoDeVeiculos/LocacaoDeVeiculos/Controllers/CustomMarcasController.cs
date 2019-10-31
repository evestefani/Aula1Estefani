using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LocacaoDeVeiculos.Controllers
{
    public partial class MarcasController : ApiController
    {
        [HttpGet]
        [Route("Api/Marcas/CustomMarcaQuery")]
        public object CustomMarcasQuery()
        {
            var listaDeMarcas = db.Marcas.ToList();

            var retornoMarcas = from mar in listaDeMarcas
                                select new
                                {
                                    IdMarca = mar.Id,
                                    NomeMarca = mar.Nome
                                };

            return retornoMarcas;

        }

        [HttpGet]
        [Route("Api/Marcas/CustomVendasMarcaAno")]
        public object CustomVendasMarcaAnoQuery()
        {
            var listaDeVendas = db.Vendas.ToList();
            var listaDeMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listaDeMarcas
                                  join usu in listaDeMarcas
             on ven.Id equals usu.Id
                                  select new
                                  {

                                  };

            return conteudoRetorno;
        }
    }
}
