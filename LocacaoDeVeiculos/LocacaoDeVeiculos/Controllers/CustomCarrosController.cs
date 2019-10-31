using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LocacaoDeVeiculos.Controllers
{
    public partial class UsuariosController : ApiController
    {
        [HttpGet]
        [Route("Api/Carros/CustomCarroQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from car in listaDeCarros
                                  select new
                                  {
                                    IdCarro = car.Id,
                                    MarcaCarro = car.Marca,
                                    ModeloCarro = car.Modelo
                                  };

            return retornoCarros;
        }

    }
}