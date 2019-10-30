using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarrosController
    {
        [HttpGet]
        [Route("Api/Carros/CustomCarroQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from car in listaDeCarros
                                select new
                                {
                                    NomeCarro = car.Modelo,
                                    CarroId = car.Id
                                };

            return retornoCarros;
        }

        [HttpGet]
        [Route("Api/Carros/CustomMarcaQuery")]
        public object CustomMarcasQuery()
        {
            var listaDeMarcas = db.Marcas.ToList();

            var retornoMarcas = from mar in listaDeMarcas
                                select new
                                {
                                    NomeMarca = mar.Nome,
                                    MarcaId = mar.Id
                                };

            return retornoMarcas;
        }

        [HttpGet]
        [Route("Api/Carros/CustomUsuarioQuery")]
        public object CustomUsuariosQuery()
        {
            var listaDeUsuarios = db.Usuarios.ToList();

            var retornoUsuarios = from usu in listaDeUsuarios
                                  select new
                                  {
                                      NomeUsuario = usu.Usuario1,
                                      UsuarioId = usu.Id
                                  };

            return retornoUsuarios;
        }

        [HttpGet]
        [Route("Api/Carros/CustomVendaQuery")]
        public object CustomVendasQuery()
        {
            var listaDeVendas = db.Vendas.ToList();

            var retornoVendas = from ven in listaDeVendas
                                select new
                                {
                                    VendaCarro = ven.Carro,
                                    VendaId = ven.Id
                                };

            return retornoVendas;
        }


        [HttpGet]
        [Route("Api/Carros/CustomCarrosOnMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listMarcas
                                  join car in listCarros
             on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };

            return conteudoRetorno;

        }

        [HttpGet]
        [Route("Api/Carros/CustomCarroOnUsuario/{IdCarro}")]
        public object CustomCarroOnUsuario(int IdCarro)
        {
            var listCarros = db.Carros.ToList();
            var listUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from car in listCarros
                                  join usu in listUsuarios
                                  on car.UsuInc equals usu.Id
                                  where car.Id == IdCarro
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      UsuarioId = usu.Id,
                                      UsuarioNome = usu.Usuario1
                                  };

            return conteudoRetorno;

        }
    }
}