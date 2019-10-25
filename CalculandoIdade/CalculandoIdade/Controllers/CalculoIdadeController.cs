using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {


        /// <summary>
        /// Retorna o nome da aplicação
        /// </summary>
        /// <returns>Retorna o que o nosso app faz</returns>
        public string Get()
        {
            return "App pra poder beber hoje";
        }

        public string Get(int anoNascimento, string nomeUsuario = "Default")
        {

            if ((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $"Olá {nomeUsuario}, de acordo com os nosso calcúlos realizados no serivdor você pode despirocar a partir de agora!";
            }
            else
            {
                return $"Sorry {nomeUsuario}, o seu tempo de desmamar ainda não terminou!";
            }

           
        }
    }

}
