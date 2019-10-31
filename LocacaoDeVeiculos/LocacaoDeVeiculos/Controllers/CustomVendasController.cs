using LocacaoDeVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LocacaoDeVeiculos.Controllers
{
    public partial class VendasController : ApiController
    {
        [HttpGet]
        [Route("Api/Vendas/CustomVendaQuery")]
        public object CustomVendasQuery()
        {
            var listaDeVendas = db.Vendas.ToList();

            var retornoVendas = from ven in listaDeVendas
                                select new
                                {
                                    IdVendas = ven.Id,
                                    Quantidadevendas = ven.Quantidade,
                                    ValorVendas = ven.Valor
                                };

            return retornoVendas;
        }

        [HttpGet]
        [Route("Api/Vendas/CustomVendasAno/{ano}")]
        public object CustomVendasAnoQuery(int ano)
        {
            var listaDeVendas = db.Vendas.ToList();

            var retornoVendas = from ven in listaDeVendas
                                where ven.DatInc.Year == ano
                                select new
                                {
                                    ValorVendas = ven.Valor
                                };

            return retornoVendas;
        }

        [HttpGet]
        [Route("Api/Vendas/CustomVendasAnoUsuario/{id}/{ano}")]
        public object CustomVendasAnoUsuarioQuery(int ano, int id)
        {
            var listaDeVendas = db.Vendas.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join usu in listaDeUsuarios                
                                  on ven.UsuInc equals usu.Id
                                  where ven.DatInc.Year == ano
                                  && id == usu.Id
                                  select new
                                  {
                                      VendaPeloUsuario = usu.Id,
                                      NomeUsuario = usu.Usuario1,
                                      ValorVenda = ven.Valor
                                  };

            return conteudoRetorno;
        }

    }
}