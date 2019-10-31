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
        [Route("Api/Usuarios/CustomUsuarioQuery")]
        public object CustomUsuarioQuery()
        {
            var listaDeUsuarios = db.Usuarios.ToList();

            var retornoUsuarios = from usu in listaDeUsuarios
                                  select new
                                  {
                                    IdUsuario = usu.Id,
                                    NomeUsu = usu.Usuario1
                                  };

            return retornoUsuarios;
        }

    }
}